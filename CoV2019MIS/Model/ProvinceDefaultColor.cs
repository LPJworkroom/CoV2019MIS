using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    [Serializable]
    public class ProvinceDefaultColor
    {
        public string province { get; set; }
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int rOffset { get; set; }
        public int gOffset { get; set; }
        public int bOffset { get; set; }

        public ProvinceDefaultColor()
        {
            
        }

        public ProvinceDefaultColor(string province,int r,int g,int b,int ro,int go,int bo)
        {
            this.province = province;
            this.r = r;
            this.g = g;
            this.b = b;
            this.rOffset = ro;
            this.gOffset = go;
            this.bOffset = bo;
        }
    }
}
