using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class ProvinceSumData
    {
        public string province { get; set; }
        public int confirmed { get; set; }
        public int suspect { get; set; }
        public int death { get; set; }

        public ProvinceSumData()
        {

        }

        public ProvinceSumData(string province, int confirmed, int suspect, int death)
        {
            this.province = province;
            this.confirmed = confirmed;
            this.suspect = suspect;
            this.death = death;
        }
    }
}
