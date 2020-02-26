using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model
{
    public class PlagueNews
    {
        private List<String[]> plagueData;
        private Dictionary<String, String> urlDict=new Dictionary<string, string>();
        private ListBox plagueNews;

        public PlagueNews(List<String[]> plagueData,ListBox plagueNews)
        {
            this.plagueNews = plagueNews;
            this.plagueData = plagueData;
            foreach(var strArr in this.plagueData)
            {
                this.urlDict.Add(strArr[0], strArr[1]);
                this.plagueNews.Items.Add(strArr[0]);
            }
        }

        public void titleClicked()
        {
            System.Diagnostics.Process.Start(this.plagueData[this.plagueNews.SelectedIndex][1]);
        }
    }
}
