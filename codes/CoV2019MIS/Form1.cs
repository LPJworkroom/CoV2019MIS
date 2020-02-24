using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Model;

namespace CoV2019MIS
{
    public partial class Form1 : Form
    {
        private Overallinfo overallInfo;    //概况信息类
        private ProvinceRank provinceRank;  //省份数量排名类
	    //private plagueMap;	//疫情地图类
	    private HistoryChart historyChart;	//历史折线图类
	    private PlagueNews plagueNews;	//疫情新闻类
	    private PlagueKnowledge plagueKnowledge;	//疫情知识类
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*load overall info control*/
            int[] todayData = { 1, 2, 3 },sumData= { 4, 5, 6 };
            this.overallInfo = new Overallinfo(new Label[]{(Label)Controls.Find("LabelTodayConfirmed",true)[0],
                                                (Label)Controls.Find("LabelTodaySuspect",true)[0],
                                                (Label)Controls.Find("LabelTodayDeath",true)[0]},
                                               new Label[]{(Label)Controls.Find("LabelSumConfirmed",true)[0],
                                                (Label)Controls.Find("LabelSumSuspect",true)[0],
                                                (Label)Controls.Find("LabelSumDeath",true)[0],},
                                                todayData,
                                                sumData);
            /*load province rank control*/
            String[] proName = { "江苏", "北京", "上海" };
            int[][] datas = {
                new int[]{ 1, 2, 3 },
                new int[]{ 2, 3, 4 },
                new int[]{ 3, 4, 5 }
            };
            Dictionary<String, int[]> proData = new Dictionary<string, int[]>();
            for (int i = 0; i < 3; i++)
                proData[proName[i]] = datas[i];
            this.provinceRank = new ProvinceRank(proData, (DataGridView)Controls.Find("DataGridView", true)[0]);
            /*load history chart control*/
            String[] dates = {"1月1日", "1月2日", "1月3日", "1月4日" };
            int[][] dailyDatas = { 
                new int[]{1,2,3 }, 
                new int[]{12,32,1 }, 
                new int[]{ 323,1,21}, 
                new int[]{2,12,32 } };
            List<DailyData> dailydatas=new List<DailyData>();
            for (int i=0;i<dates.Length;i++)
                dailydatas.Add(new DailyData(dates[i], dailyDatas[i][0], dailyDatas[i][1], dailyDatas[i][2]));
            this.historyChart = new HistoryChart(dailydatas,(Chart)Controls.Find("Chart1",true)[0]);
            /*load news*/
            List<String[]> newsList=new List<string[]>();
            String[][]newsData ={ new String[]{"多迭代","https://cn.bing.com" }, 
                                  new String[]{"sdfsdf", "https://cn.bing.com" }, 
                                  new String[]{"ssss", "https://cn.bing.com" } };
            foreach(var strArr in newsData)
                newsList.Add(strArr);
            this.plagueNews = new PlagueNews(newsList, (ListBox)Controls.Find("listbox1", true)[0]);
            /*load knowledges*/
            List<String[]> knowList=new List<string[]> ();
            String[][] knowDatas = { new string[] { "标题1","辟谣","锁锁缩缩梭"},
                                     new string[] { "标题2","辟谣","是的是的梭"},
                                     new string[] { "标题3","辟谣","锁锁缩的梭"},};
            foreach (var strArr in knowDatas)
                knowList.Add(strArr);
            this.plagueKnowledge = new PlagueKnowledge(knowList,(RichTextBox)Controls.Find("richTextBox1",true)[0],
                                    (Label)Controls.Find("label13", true)[0], (Label)Controls.Find("label14", true)[0],
                                    (Button)Controls.Find("button1",true)[0], (Button)Controls.Find("button2", true)[0]);
        }


        private void DataGridView_Sorted(object sender, EventArgs e)
        {
            /*regenerate row number after header clicked*/
            /*give row number*/
            DataGridView dgv= (DataGridView)(sender);
            ProvinceRank.generateRowNumber(dgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.plagueKnowledge.lBClicked();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.plagueKnowledge.rBClicked();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            /*after double click news title open browser*/
            this.plagueNews.titleClicked();
        }
    }
}
