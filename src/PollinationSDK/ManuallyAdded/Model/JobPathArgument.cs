
namespace PollinationSDK
{
    public partial class JobPathArgument
    {
        public void IsAssetUploaded(bool uploaded)
        {
            if (this.Annotations == null)
                this.Annotations = new System.Collections.Generic.Dictionary<string, string>();

            var p = "Uploaded";
            var v = uploaded ? "true" : "false";

            if (this.Annotations.TryGetValue(p, out var path))
            {
                this.Annotations[p] = v;
            }
            else
            {
                this.Annotations.Add(p, v);
            }
        }

        public bool IsAssetUploaded()
        {
            if (this.Annotations == null)
                return false;

            if (this.Annotations.TryGetValue("Uploaded", out var isUploaded))
            {
                return isUploaded == "true";
            }

            return false;

        }
    }
}