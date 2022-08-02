

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class LocalRunArguments
    {

        private List<AnyOf<JobArgument, JobPathArgument>> _args { get; }

        public LocalRunArguments(List<AnyOf<JobArgument, JobPathArgument>> arguments)
        {
            this._args = arguments;
        }

        //public void Validate(RecipeInterface recipe)
        //{
        //    // check if any required parameters are missing
        //    var resuired = recipe.InputList.Where(_ => _.Required).Select(_ => _.Name);

        //    var missingRequired = resuired.Where(_ => !this._dic.ContainsKey(_));
        //    if (missingRequired.Any())
        //    {
        //        var msg = string.Join(",", missingRequired);
        //        throw new ArgumentException($"Missing required parameters [{msg}]!");
        //    }
        //}

        private List<AnyOf<JobArgument, JobPathArgument>> CopyLocalPathArgs(string folder)
        {
            var newArgs = new List<AnyOf<JobArgument, JobPathArgument>>();
            foreach (var item in this._args)
            {
                var argName = string.Empty;
                object argValue = string.Empty;

                if (item.Obj is JobPathArgument p)
                {
                    //copy to folder
                    var tempPath = (p.Source.Obj as PollinationSDK.ProjectFolder).Path;
                    var pathName = string.Empty;
                    if (System.IO.Path.HasExtension(tempPath)) // file type
                    {
                        if (!File.Exists(tempPath))
                            throw new ArgumentException($"Failed to find path argument {tempPath}");
                        var fileName = Path.GetFileName(tempPath);
                        var newPath = Path.Combine(folder, fileName);
                        File.Copy(tempPath, newPath, true);
                        if (!File.Exists(newPath))
                            throw new ArgumentException($"Failed to find path argument {newPath}");

                        pathName = fileName;
                    }
                    else // folder type
                    {
                        if (!Directory.Exists(tempPath))
                            throw new ArgumentException($"Failed to find path argument {tempPath}");

                        // copy all contents from tempPath to folder
                        var targetDir = folder;
                        Directory.CreateDirectory(targetDir);
                        var subDirs = Directory.GetDirectories(tempPath, "*", SearchOption.AllDirectories);
                        foreach (var dir in subDirs)
                        {
                            Directory.CreateDirectory(dir.Replace(tempPath, targetDir));
                        }

                        var subfiles = Directory.GetFiles(tempPath, "*.*", SearchOption.AllDirectories);
                        foreach (var f in subfiles)
                        {
                            var targetPath = f.Replace(tempPath, targetDir);
                            File.Copy(f, targetPath, true);
                        }

                        pathName = folder;
                    }
                 
                  
                    newArgs.Add(new JobPathArgument(p.Name, new ProjectFolder(path: pathName)));

                }
                else if (item.Obj is JobArgument arg)
                {
                    newArgs.Add(arg.DuplicateJobArgument());
                }
            }
            return newArgs;
        }


        public string SaveToFolder(string folder)
        {
            var dic = new Dictionary<string, object>();
            var args = CopyLocalPathArgs(folder);
            foreach (var item in args)
            {
                var argName = string.Empty;
                object argValue = string.Empty;

                if (item.Obj is JobPathArgument p)
                {
                    argName = p.Name;
                    argValue = (p.Source.Obj as PollinationSDK.ProjectFolder).Path;
                }
                else if (item.Obj is JobArgument arg)
                {
                    argName = arg.Name;
                    argValue = arg.Value;
                }

                dic.Add(argName, argValue);
            }

            //// save original List<AnyOf<JobArgument, JobPathArgument>> to inputs_raw.json
            //string rawJson = JsonConvert.SerializeObject(args, JsonSetting.AnyOfConvertSetting);
            //var rawPath = Path.Combine(folder, "inputs_raw.json");
            //File.WriteAllText(rawPath, rawJson);


            string json = JsonConvert.SerializeObject(dic, Formatting.Indented);
            var path = Path.Combine(folder, "inputs.json");
            File.WriteAllText(path, json);
            if (!File.Exists(path))
                throw new ArgumentException("Failed to save inputs.json");
            return path;
        }

        public static string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, JsonSetting.AnyOfConvertSetting);
        }

        public static object FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<List<AnyOf<JobArgument, JobPathArgument>>>(json, JsonSetting.AnyOfConvertSetting);
            return obj;
        }

    }

}
