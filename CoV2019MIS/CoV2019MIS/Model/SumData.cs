using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    class SumData
    {
        public int confirmed { get; set; }
        public int suspect { get; set; }
        public int death { get; set; }

        public SumData()
        {

        }

        public SumData( int confirmed, int suspect, int death)
        {
            this.confirmed = confirmed;
            this.suspect = suspect;
            this.death = death;
        }
    }
}
