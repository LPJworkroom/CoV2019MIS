using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Model
{
    public class PlagueMap
    {
        /*province default color,now color and plague color*/
        Dictionary<String, Color> befCol=new Dictionary<string, Color>(), 
            nowCol=new Dictionary<string, Color>();
        /*province sum data*/
        Dictionary<String, int[]> sumData=new Dictionary<string, int[]>();
        /*plague color with confirmed bound,
         *max bound must be infinity
         */
        List<int> plgBound=new List<int>();
        List<Color> plgCol=new List<Color>();
        /*the map*/
        PictureBox plagueMap;
        Bitmap img;

        
        public PlagueMap(PictureBox plagueMap, Dictionary<String, int[]> befCol,
                        Dictionary<String, int[]> sumData,Dictionary<int,int[]> plgCol)
        {
            this.plagueMap = plagueMap;
            this.img=plagueMap.Image;
            this.sumData = sumData;
            foreach (var prov in befCol.Keys)
            {
                /*convert rgb array dict into Color dict*/
                int[] bef = befCol[prov];
                this.befCol[prov] = Color.FromArgb(1,bef[0], bef[1], bef[2]);
            }
            foreach (var b in plgCol.Keys)
                plgBound.Add(b);
            plgBound.Sort();
            foreach (var b in plgBound)
            {
                /*convert rgb array dict into Color dict*/
                int[] col=plgCol[b];
                this.plgCol.Add(Color.FromArgb(1, col[0], col[1], col[2]));
            }
            /*show the map*/
            colorBySum();
        }

        private void colorBySum()
        {
            /*color the default map by severity*/
            foreach(var prov in befCol.Keys)
            {
                Color befColor = befCol[prov],nowColor=getPlgCol(sumData[prov][0]);
                replaceColor(befColor,nowColor);
                nowCol[prov] = nowColor;
            }
        }

        private void replaceColor(Color bef,Color now)
        {
            /*replace map's bef color to now*/
            for (int x=0;x<img.Width;x++)
                for (int y=0;y<img.Height;y++)
                {
                    if (img.GetPixel(x, y) == bef)
                        img.SetPixel(x, y, now);
                }
        }

        private Color getPlgCol(int num)
        {
            int index = plgBound.BinarySearch(num);
            index = index >= 0 ? index : (~index);
            return plgCol[index];
        }
    }
}
