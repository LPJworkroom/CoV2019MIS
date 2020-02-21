using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class PlagueColor
    {
        public int floor { get; set; }
        public int ceil { get; set; }
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public PlagueColor()
        {

        }
        public PlagueColor(int floor, int ceil, int r, int g, int b)
        {
            this.floor = floor;
            this.ceil = ceil;
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
