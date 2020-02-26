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
using BLL;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CoV2019MIS
{
    public partial class 疫情信息管理系统 : Form
    {
        private double ratio = 1.25,imgRatio=1.2;
        private Overallinfo overallInfo;    //概况信息类
        private ProvinceRank provinceRank;  //省份数量排名类
	    private PlagueMap plagueMap;	//疫情地图类
	    private HistoryChart historyChart;	//历史折线图类
	    private PlagueNews plagueNews;	//疫情新闻类
	    private PlagueKnowledge plagueKnowledge;	//疫情知识类
        public 疫情信息管理系统()
        {
            InitializeComponent();
        }

        public void initControls()
        {
            /*load overall info control*/
            int[] todayData = { 0, 0, 0 }, sumData = { 0, 0, 0 };
            /*get data from DB*/
            IProvinceSumDataBLL psdb = new ProvinceSumDataBLL();
            List<ProvinceSumData> psd = psdb.selectALL();
            foreach (var data in psd)
            {
                sumData[0] += data.confirmed;
                sumData[1] += data.suspect;
                sumData[2] += data.death;
            }
            this.overallInfo = new Overallinfo(new Label[]{(Label)Controls.Find("LabelSumConfirmed",true)[0],
                                                (Label)Controls.Find("LabelSumSuspect",true)[0],
                                                (Label)Controls.Find("LabelSumDeath",true)[0],},
                                                todayData,
                                                sumData);
            /*load province rank control*/
            String[] proName = { };
            int[][] datas = { };
            /*get data from DB*/
            Dictionary<String, int[]> proData = new Dictionary<string, int[]>();
            foreach (var data in psd)
                proData[data.province] = new int[] {data.confirmed,data.suspect,data.death };
            this.provinceRank = new ProvinceRank(proData, (DataGridView)Controls.Find("DataGridView", true)[0]);
            /*load history chart control*/
            IProvinceDailyDataBLL pddb = new ProvinceDailyDataBLL();
            List<ProvinceDailyData> pdd = pddb.selectALL();
            Dictionary<String, int[]> sdd=new Dictionary<string, int[]>();
            List<DailyData> dailydatas = new List<DailyData>();
            for (int i = 0; i < pdd.Count; i++)
            {
                sdd[pdd[i].date] = new int[] { 0, 0, 0 };
            }
            foreach (var pair in sdd)
            {
                List<ProvinceDailyData> dd = pddb.selectByDate(pair.Key);
                foreach(var day in dd)
                {
                    sdd[pair.Key][0] += day.confirmed;
                    sdd[pair.Key][1] += day.suspect;
                    sdd[pair.Key][2] += day.death;
                }
                
            }
                
            int yesterdayCon = 0;
            foreach (var pair in sdd)
            {
                dailydatas.Add(new DailyData(pair.Key, pair.Value[0]-yesterdayCon, pair.Value[1], pair.Value[2]));
                yesterdayCon = pair.Value[0];
            }
            this.historyChart = new HistoryChart(dailydatas, (Chart)Controls.Find("Chart1", true)[0]);
            /*load news*/
            INewsDataBLL ndb = new NewsDataBLL();
            List<NewsData> nd = ndb.selectALL();
            List<String[]> newsList = new List<string[]>();
            foreach (var news in nd)
            {
                newsList.Add(new String[]{news.title,news.url });
            }
                
            this.plagueNews = new PlagueNews(newsList, (ListBox)Controls.Find("listbox1", true)[0]);
            /*load knowledges*/
            IKnowledgeDataBLL kdb = new KnowledgeDataBLL();
            List<KnowledgeData> kd = kdb.selectALL();
            List<string[]> knowList = new List<string[]>();
            foreach (var strArr in kd)
                knowList.Add(new string[] { strArr.title, strArr.type, strArr.content });
            this.plagueKnowledge = new PlagueKnowledge(knowList, (RichTextBox)Controls.Find("richTextBox1", true)[0],
                                    (Label)Controls.Find("label13", true)[0], (Label)Controls.Find("label14", true)[0],
                                    (Button)Controls.Find("button1", true)[0], (Button)Controls.Find("button2", true)[0]);
            /*load plauge map*/
            IProvinceDefaultColorBLL pdcb = new ProvinceDefaultColorBLL();
            List<ProvinceDefaultColor> pdc=pdcb.selectALL();
            Dictionary<String, Color> befColor = new Dictionary<string, Color>(),
                colOffset = new Dictionary<string, Color>();
            foreach (var prov in pdc)
            {
                befColor[prov.province] = Color.FromArgb(255, prov.r, prov.g, prov.b);
                colOffset[prov.province] = Color.FromArgb( prov.rOffset,prov.gOffset,prov.bOffset );
            }

            IPlagueColorBLL pcb = new PlagueColorBLL();
            List<PlagueColor> pc = pcb.selectALL();
            Dictionary<int, Color> plgColor = new Dictionary<int, Color>();
            foreach(var p in pc)
                plgColor[p.floor]= Color.FromArgb(255, p.r, p.g, p.b);

            this.plagueMap = new PlagueMap(this.toolTip1, befColor,colOffset, proData, plgColor, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initControls();
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var img = plagueMap.getImg();
            e.Graphics.DrawImage(img, 390, 60,(float)(img.Width*(imgRatio/ratio)),(float)(img.Height*imgRatio/ratio));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*show tool tip of hovered province's plague*/
            var img = plagueMap.getImg();
            Rectangle bound = new Rectangle(390, 60, (int)(img.Width * (imgRatio / ratio)), (int)((img.Height * imgRatio / ratio)));
            //Rectangle bound = new Rectangle((int)(420), (int)(90), (int)(img.Width/), (int)(img.Height));
            Console.WriteLine((int)(img.Width / ratio));
            Console.WriteLine((int)(img.Height / ratio));
            int x = e.X,y=e.Y;
            String prov = "";
            //int x = (int)(MousePosition.X), y = (int)(MousePosition.Y);
            if (contains(bound, x, y))
            {
                
                plagueMap.mapHovered((int)((x - bound.X)*ratio/imgRatio), (int)((y - bound.Y) * ratio / imgRatio)); 
            }
        }

        private bool contains(Rectangle rect,int x,int y)
        {
            return rect.X <= x && rect.X + rect.Width >= x &&
                   rect.Y <= y && rect.Y + rect.Height >= y;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            /*update plague info and news*/
            UpdateDataBLL udb = new UpdateDataBLL();
            if (!udb.updatePlague())
            {
                MessageBox.Show("更新失败，网站正忙");
                return;
            }

            if (!udb.updateNews())
            {
                MessageBox.Show("更新失败，网站正忙");
                return;
            }
            MessageBox.Show("更新成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
