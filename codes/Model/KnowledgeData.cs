using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class KnowledgeData
    {
        public string type { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public KnowledgeData()
        {

        }

        public KnowledgeData(string type,string title, string content)
        {
            this.type = type;
            this.title = title;
            this.content = content;
        }
    }
}
