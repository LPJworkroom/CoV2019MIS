using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoV2019MIS
{
    public partial class Form1 : Form
    {
        private dynamic overallInfo;    //概况信息类
     //   private provinceRank;	//省份数量排名类
	    //private plagueMap;	//疫情地图类
	    //private historyChart;	//历史折线图类
	    //private plagueNews;	//疫情新闻类
	    //private plagueKnowledge;	//疫情知识类
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.overallInfo = this.Controls["OverAllInfo"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void OverAllInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProvinceRank_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
