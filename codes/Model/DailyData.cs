using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class DailyData
    {
        public string date { get; set; }
        public int confirmed { get; set; }
        public int suspect { get; set; }
        public int death { get; set; }

        public DailyData()
        {

        }

        public DailyData(string date, int confirmed, int suspect, int death)
        {
            this.date = date;
            this.confirmed = confirmed;
            this.suspect = suspect;
            this.death = death;
        }
    }
}
