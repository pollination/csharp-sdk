
extern alias LBTNewtonsoft;
using LBTNewtonsoft::Newtonsoft.Json;

namespace PollinationSDK.Wrapper
{
    public class RunInputAsset : RunAssetBase
    {
        [JsonConstructorAttribute]
        protected RunInputAsset()
        {
        }
        public RunInputAsset(Interface.Io.Inputs.IStep dagInput, string runSource = default)
        {
            if (dagInput == null)
                return;

            // get name
            this.Name = dagInput.Name;
            this.Description = dagInput.Description;

            // check path type
            this.RelativePath = dagInput.GetInputPath();
            

            // value type
            this.Value = dagInput.GetInputValue();

            // cloud source: CLOUD:mingbo/demo/1D725BD1-44E1-4C3C-85D6-4D98F558DE7C
            // local source: LOCAL:C\Users\mingo\simulaiton\1D725BD1
            this.RunSource = runSource;

            if (dagInput.IsPathType())
                this.PathType = dagInput is StepFolderInput ? "folder" : "file";
        }

        public override AssetBase Duplicate()
        {
            var json = JsonConvert.SerializeObject(this, Formatting.None);
            return JsonConvert.DeserializeObject<RunInputAsset>(json);
        }


    }

}
