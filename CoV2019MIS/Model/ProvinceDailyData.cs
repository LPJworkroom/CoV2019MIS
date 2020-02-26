using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class ProvinceDailyData
    {
        public string province { get; set; }
        public string date { get; set; }
        public int confirmed { get; set; }
        public int suspect { get; set; }
        public int death { get; set; }

        public ProvinceDailyData()
        {
            
        }

        public ProvinceDailyData(string province,string date,int confirmed,int suspect,int death)
        {
            this.province = province;
            this.date = date;
            this.confirmed = confirmed;
            this.suspect = suspect;
            this.death = death;
        }
    }
}
