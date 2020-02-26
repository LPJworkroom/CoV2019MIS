using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Resources;
using System.Windows.Forms;
using System.Reflection;
namespace Model
{
    public class PlagueMap
    {
        /*province default color,now color and plague color*/
        Dictionary<String, Color> befCol=new Dictionary<string, Color>(),
            colOffset=new Dictionary<string, Color>(),
            nowCol=new Dictionary<string, Color>();
        /*from now color to province name*/
        Dictionary<Color, String> color2Prov=new Dictionary<Color, string>();
        /*province sum data*/
        Dictionary<String, int[]> sumData=new Dictionary<string, int[]>();
        /*plague color with confirmed bound,
         *max bound must be infinity
         */
        List<int> plgBound=new List<int>();
        List<Color> plgCol=new List<Color>();
        Bitmap img;
        Form parent;
        ToolTip toolTip;
        
        public PlagueMap(ToolTip toolTip,Dictionary<String, Color> befCol, Dictionary<String, Color> colOffset,
                        Dictionary<String, int[]> sumData,Dictionary<int, Color> plgCol,Form parent)
        {
            //this.img=plagueMap.Image;
            //img= (Bitmap)Bitmap.FromFile("C:\\Users\\lpjworkroom\\Desktop\\CoV2019MIS\\CoV2019MIS\\CoV2019MIS\\Resources\\map.gif");
            img = (Bitmap)Bitmap.FromFile("..\\..\\Resources\\map.gif");
            //ResourceManager rm = new ResourceManager("myResources", Assembly.GetExecutingAssembly());

            //img = (Bitmap)rm.GetObject("map.gif");

            this.colOffset = colOffset;
            this.toolTip = toolTip;
            this.parent = parent;
            this.sumData = sumData;
            this.befCol=befCol;
            foreach (var b in plgCol.Keys)
                plgBound.Add(b);
            plgBound.Sort();
            foreach (var b in plgBound)
            {
                /*convert rgb array dict into Color dict*/
                Color col=plgCol[b];
                this.plgCol.Add(col);
            }
            /*show the map*/
            colorBySum();
        }

        private void colorBySum()
        {
            for (int x = 0; x < img.Width; x++)
                for (int y = 0; y < img.Height; y++)
                {
                    Color tmp = img.GetPixel(x, y);
                    String prov = null;
                    foreach(var pair in befCol)
                    {
                        if (pair.Value == tmp)
                        {
                            prov = pair.Key;break; ;
                        }
                    }
                    if (prov!= null)
                    {
                        Color befColor = tmp, nowColor = substract(getPlgCol(sumData[prov][0]), this.colOffset[prov]);
                        img.SetPixel(x, y, nowColor);
                        nowCol[prov] = nowColor;
                        color2Prov[nowColor] = prov;
                    }
                }
        }

        private void replaceColor(Color bef,Color now)
     {
            int cnt = 0;
            /*replace map's bef color to now*/
            //Console.WriteLine(img.GetPixel(100, 100));
            for (int x=0;x<img.Width;x++)
                for (int y=0;y<img.Height;y++)
                {
                    if (img.GetPixel(x, y) == bef)
                    {
                        img.SetPixel(x, y, now);
                        cnt++;
                    }
                }
            //Console.WriteLine(cnt);
        }

        private Color getPlgCol(int num)
        {
            int index = plgBound.BinarySearch(num);
            index = index >= 0 ? index : (~index);
            return plgCol[index];
        }

        public bool mapHovered(int x,int y)
        {
            /*return if province hovered and set tooltip*/
            //Console.Write("get pixel from");
            //Console.WriteLine(string.Format("{0} {1}", x, y));
            Color col = img.GetPixel(x, y);
            if (color2Prov.ContainsKey(col))
            {
                //Console.WriteLine(col);
                //Console.WriteLine(String.Format("{0} {1}", x, y));
                toolTip.ToolTipTitle = color2Prov[col];
                var data = this.sumData[color2Prov[col]];
                toolTip.Active = true;
                toolTip.SetToolTip(parent, string.Format("确诊：{0}\n疑似：{1}\n死亡：{2}",
                                            data[0], data[1], data[2]));
                return true;
            }
            toolTip.Active = false;
            return false;
        }

        public Bitmap getImg()
        {
            return img;
        }

        private Color substract(Color a,Color b)
        {
            return Color.FromArgb(255, a.R + b.R, a.G + b.G, a.B +b.B);
        }
    }
}
