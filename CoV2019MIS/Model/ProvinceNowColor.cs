using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class ProvinceNowColor
    {
        public string province { get; set; }
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public ProvinceNowColor()
        {

        }
        public ProvinceNowColor(string province, int r, int g, int b)
        {
            this.province = province;
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
