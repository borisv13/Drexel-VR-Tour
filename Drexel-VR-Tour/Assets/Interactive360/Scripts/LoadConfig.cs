using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace Interactive360.Utils
{
    public class LoadConfig : MonoBehaviour
    {
        //public string path = "test";
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public string readTextFileFromResources()
        {
            string path = "web";
            TextAsset textContent = (TextAsset)Resources.Load(path);
            string content = textContent.text;
            return content;
        }

        public string readFileFromStreamingAssets()
        {
            string path = "Web.config";
            path = Path.Combine(Application.streamingAssetsPath, path);
            string[] content = File.ReadAllLines(path);
            foreach (var item in content)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    item.Trim();
                    if (item.StartsWith("#"))
                    {
                        string[] info = item.Split(':');
                        if (info[0] == "#Platform")
                        {
                            return info[1];
                        }
                    }
                }
            }
            return "Null";
        }
    }
}

