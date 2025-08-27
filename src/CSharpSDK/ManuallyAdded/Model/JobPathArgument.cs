namespace PollinationSDK
{
    public partial class JobPathArgument
    {
        private void SetAnnotation(string key, string value)
        {
            if (this.Annotations == null)
                this.Annotations = new System.Collections.Generic.Dictionary<string, string>();

            var p = key;
            var v = value;

            if (this.Annotations.TryGetValue(p, out var path))
            {
                this.Annotations[p] = v;
            }
            else
            {
                this.Annotations.Add(p, v);
            }
        }

        public void IsAssetUploaded(bool uploaded)
        {
            var p = "Uploaded";
            var v = uploaded ? "true" : "false";
            SetAnnotation(p, v);
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

        public void TagCloudProjectSlug(string projSlug)
        {
            SetAnnotation("Project", projSlug);
        }

        public string CloudProjectSlug()
        {
            if (this.Annotations == null)
                return null;

            if (this.Annotations.TryGetValue("Project", out var proj))
            {
                return proj;
            }

            return null;
        }

        public string ToUserFriendlyString(bool withProjectSlug)
        {
            var uploaded = this.IsAssetUploaded();

            var p = (this.Source.Obj as ProjectFolder)?.Path;
            var hint = "PATH";
            if (uploaded)
            {
                hint = "CLOUD";
                if (withProjectSlug)
                {
                    var slug = this.CloudProjectSlug();
                    hint = string.IsNullOrEmpty(slug) ? hint : $"{hint}:{slug}";
                }
            }
            else
            {
                p = System.IO.Path.GetFileName(p);
            }


            var text = $"{hint}/{p}";
            if (!string.IsNullOrEmpty(this.Name))
                text = $"#{this.Name}:{text}";
            return text;

        }
    }
}