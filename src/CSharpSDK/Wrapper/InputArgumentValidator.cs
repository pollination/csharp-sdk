
extern alias LBTNewtonsoft;  extern alias LBTRestSharp; using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using PollinationSDK;

namespace PollinationSDK.Wrapper
{
    public class InputArgumentValidator
    {
        public PollinationSDK.Interface.Io.Inputs.IDag DagInput { get; set; }
        /// <summary>
        /// Platform specific DagInputAlias
        /// </summary>
        public PollinationSDK.Interface.Io.Inputs.IAlias DagInputAlias { get; set; }


        public string Name => this.DagInput?.Name;

        public List<PollinationSDK.IOAliasHandler> Handlers => this.DagInputAlias?.Handler;
        public PollinationSDK.DAGLinkedInputAlias LinkedAlias => this.DagInputAlias as PollinationSDK.DAGLinkedInputAlias;

        public InputArgumentValidator(PollinationSDK.Interface.Io.Inputs.IDag dagInput, string platform)
        {
            this.DagInput = dagInput;
            this.DagInputAlias = dagInput.GetAlias(platform);
        }

        public static object CheckAndValidate(PollinationSDK.Interface.Io.Inputs.IDag dagInput, string platform, object value, HandlerChecker handlerChecker)
        {
            if (dagInput == null)
                throw new ArgumentNullException(nameof(dagInput));

            if (value == null) return null;

            // check CloudReferenceAsset
            if (value is CloudReferenceAsset cloudRef)
                value = cloudRef.ToJobPathArgument();

            // do nothing for the cloud referenced file path
            if (value is JobPathArgument path && path.IsAssetUploaded())
                return path;

            var vd = new InputArgumentValidator(dagInput, platform);
            return vd.CheckAndValidate(value, handlerChecker);
        }

        /// <summary>
        /// Checks the data with alias' JsonSchema spec (if any), followed by checks of handlers and original DagInput's JsonSchema spec.
        /// It runs in order of following: ValidateWithAliasSpec, CheckInputWithHandler, and CheckAndValidate.
        /// </summary>
        /// <param name="value">Data to be checked. Null will be skipped</param>
        /// <param name="handlerChecker"></param>
        /// <returns>Checked value by handler, return null if any checks failed and an ArgumentException will be thrown.</returns>
        public object CheckAndValidate(object value, HandlerChecker handlerChecker)
        {
            if (value == null) return null;
            if (this.DagInputAlias == null) return value; // return input value if no input alias found
            
            // validate Alias input
            if (!this.ValidateWithAliasSpec(value)) return null;

            // convert with handlers
            var obj = this.CheckInputWithHandler(value, handlerChecker);
            // validate input specs
            if (!this.ValidateWithSpec(obj)) return null;
            return obj;
        }

        public bool ValidateWithSpec(object value)
        {
            return this.DagInput.ValidateWithSpec(value);
        }

        public bool ValidateWithAliasSpec(object value)
        {
            return (this.DagInputAlias?.ValidateWithSpec(value)).GetValueOrDefault(true);
        }


        public object CheckInputWithHandler(object inputData, HandlerChecker handlerChecker)
        {
            return handlerChecker.CheckWithHandlers(inputData, this.Handlers);
        }

        public object CheckLinkedData(HandlerChecker handlerChecker, string language = "csharp")
        {
            if (this.LinkedAlias?.Handler == null)
                return null;

            var handler = this.LinkedAlias.Handler.FirstOrDefault(_ => _.Language == language);

            return handlerChecker?.CheckLinkedData(handler);
        }

        public bool IsPathType() => this.DagInput.IsPathType();


        public List<string> ValidatePathInputs(IEnumerable<string> userInputs)
        {
            var checkedValues = userInputs.Where(_ => !string.IsNullOrEmpty(_.ToString().Trim()));
            //var type = inputInfo.DagInput.GetType();

            var name = this.Name;

            foreach (var userInput in checkedValues)
            {
                var userValue = userInput.Trim();

                // validate file extension
                if (this.DagInput is PollinationSDK.DAGFileInput p)
                    CheckIfFileExist(userValue, p.Extensions);
                else if (this.DagInput is PollinationSDK.DAGFolderInput f)
                    CheckIfFolderExist(userValue);
                else if (this.DagInput is PollinationSDK.DAGPathInput path)
                {
                    FileAttributes attr = File.GetAttributes(userValue);
                    if (attr.HasFlag(FileAttributes.Directory))
                        CheckIfFolderExist(userValue);
                    else
                        CheckIfFileExist(userValue, path.Extensions);
                }
                else
                {
                    throw new ArgumentException($"Unknown input type. It most likely happens with mismatching versions!");
                }

            }

            return checkedValues.ToList();

            void CheckIfFileExist(string value, List<string> validExtensions)
            {
                if (!File.Exists(value))
                    throw new ArgumentException($"\nInput parameter \"{name}\" is not a file path or it does not exist: {value}.\nPlease use the absolute path.");
                var ext = validExtensions;
                if (ext == null) return;

                if (!ext.Any(_ => Path.GetExtension(value).EndsWith(_)))
                    throw new ArgumentException($"Input parameter \"{name}\" has the file path without [\"{string.Join(", ", ext)}\"] extension.");
            }

            void CheckIfFolderExist(string value)
            {
                if (!Directory.Exists(value))
                    throw new ArgumentException($"\nInput parameter \"{name}\" is not a directory path or it does not exist: {value}.\nPlease use the absolute path.");

            }

        }

    }

  
}
