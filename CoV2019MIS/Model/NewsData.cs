using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    class NewsData
    {
        public string title { get; set; }
        public string url { get; set; }

        public NewsData()
        {

        }

        public NewsData(string title,string url)
        {
            this.title = title;
            this.url = url;
        }
    }
}
