﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class RunOutputAsset: RunAssetBase
    {
        [JsonProperty]
        public List<IOAliasHandler> Handlers { get; private set; }

        [JsonProperty]
        public string AliasName { get; private set; }

        [JsonProperty]
        public bool IsLinkedAsset { get; private set; }

        [JsonConstructorAttribute]
        protected RunOutputAsset()
        {
        }

        public RunOutputAsset(Interface.Io.Outputs.IDag dagOutput, string platform, string runSource = default)
        {
            if (dagOutput == null)
                return;

            this.Name = dagOutput.Name;
          
            //var platform = "grasshopper";
            var dagOutputAlias = dagOutput.GetAlias(platform);
            this.IsLinkedAsset = dagOutputAlias is DAGLinkedOutputAlias;
            // override the name and description
            this.AliasName = dagOutputAlias?.Name ?? this.Name;
            this.Handlers = dagOutputAlias?.Handler;
            this.Description = dagOutputAlias?.Description ?? dagOutput.Description;

            // cloud source: CLOUD:mingbo/demo/1D725BD1-44E1-4C3C-85D6-4D98F558DE7C
            // local source: LOCAL:C\Users\mingo\simulaiton\1D725BD1
            this.RunSource = runSource;
            this.RelativePath = dagOutput.GetOutputPath();

            if (dagOutput.IsPathType()) 
                this.PathType = dagOutput is DAGFolderOutput ? "folder" : "file";

        }

        public override object CheckOutputWithHandler(object inputData, HandlerChecker handlerChecker)
        {
            handlerChecker = handlerChecker ?? DefaultHandlerChecker.Instance;
            return handlerChecker.CheckWithHandlers(inputData, this.Handlers);
        }


        public object PreloadLinkedOutputWithHandler(object inputData, HandlerChecker handlerChecker)
        {
            if (!this.IsLinkedAsset) return inputData;

            handlerChecker = handlerChecker ?? DefaultHandlerChecker.Instance;
            if ( this.Handlers?.Count != 2)
                throw new System.ArgumentException("Linked Output requires 2 handlers, and the first handler is used for preloading.");
            
            // the first handler is for preloading
            var handlerForPreload = this.Handlers.Take(1).ToList();
            return handlerChecker.CheckWithHandlers(inputData, handlerForPreload);
        }

        public override AssetBase Duplicate()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RunOutputAsset>(json);
        }
    }

}
