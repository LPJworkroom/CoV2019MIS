namespace CoV2019MIS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.OverAllInfo = new System.Windows.Forms.Panel();
            this.LabelSumDeath = new System.Windows.Forms.Label();
            this.LabelSumSuspect = new System.Windows.Forms.Label();
            this.LabelSumConfirmed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelTodayDeath = new System.Windows.Forms.Label();
            this.LabelTodaySuspect = new System.Windows.Forms.Label();
            this.LabelTodayConfirmed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlagueKnowledge = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProvinceRank = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlagueMap = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlagueNews = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HistoryChart = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.OverAllInfo.SuspendLayout();
            this.PlagueKnowledge.SuspendLayout();
            this.ProvinceRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PlagueMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlagueNews.SuspendLayout();
            this.HistoryChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "省份排名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "你知道吗？";
            // 
            // OverAllInfo
            // 
            this.OverAllInfo.Controls.Add(this.LabelSumDeath);
            this.OverAllInfo.Controls.Add(this.LabelSumSuspect);
            this.OverAllInfo.Controls.Add(this.LabelSumConfirmed);
            this.OverAllInfo.Controls.Add(this.label9);
            this.OverAllInfo.Controls.Add(this.label10);
            this.OverAllInfo.Controls.Add(this.label11);
            this.OverAllInfo.Controls.Add(this.label12);
            this.OverAllInfo.Controls.Add(this.LabelTodayDeath);
            this.OverAllInfo.Controls.Add(this.LabelTodaySuspect);
            this.OverAllInfo.Controls.Add(this.LabelTodayConfirmed);
            this.OverAllInfo.Controls.Add(this.label4);
            this.OverAllInfo.Controls.Add(this.label3);
            this.OverAllInfo.Controls.Add(this.label2);
            this.OverAllInfo.Controls.Add(this.label1);
            this.OverAllInfo.Location = new System.Drawing.Point(32, 12);
            this.OverAllInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverAllInfo.Name = "OverAllInfo";
            this.OverAllInfo.Size = new System.Drawing.Size(447, 158);
            this.OverAllInfo.TabIndex = 24;
            this.OverAllInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.OverAllInfo_Paint);
            // 
            // LabelSumDeath
            // 
            this.LabelSumDeath.AutoSize = true;
            this.LabelSumDeath.Location = new System.Drawing.Point(381, 68);
            this.LabelSumDeath.Name = "LabelSumDeath";
            this.LabelSumDeath.Size = new System.Drawing.Size(55, 15);
            this.LabelSumDeath.TabIndex = 28;
            this.LabelSumDeath.Text = "label7";
            // 
            // LabelSumSuspect
            // 
            this.LabelSumSuspect.AutoSize = true;
            this.LabelSumSuspect.Location = new System.Drawing.Point(307, 68);
            this.LabelSumSuspect.Name = "LabelSumSuspect";
            this.LabelSumSuspect.Size = new System.Drawing.Size(55, 15);
            this.LabelSumSuspect.TabIndex = 27;
            this.LabelSumSuspect.Text = "label6";
            // 
            // LabelSumConfirmed
            // 
            this.LabelSumConfirmed.AutoSize = true;
            this.LabelSumConfirmed.Location = new System.Drawing.Point(231, 68);
            this.LabelSumConfirmed.Name = "LabelSumConfirmed";
            this.LabelSumConfirmed.Size = new System.Drawing.Size(55, 15);
            this.LabelSumConfirmed.TabIndex = 26;
            this.LabelSumConfirmed.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "死亡";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "疑似";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "确诊";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "全国总计";
            // 
            // LabelTodayDeath
            // 
            this.LabelTodayDeath.AutoSize = true;
            this.LabelTodayDeath.Location = new System.Drawing.Point(155, 68);
            this.LabelTodayDeath.Name = "LabelTodayDeath";
            this.LabelTodayDeath.Size = new System.Drawing.Size(55, 15);
            this.LabelTodayDeath.TabIndex = 21;
            this.LabelTodayDeath.Text = "label7";
            // 
            // LabelTodaySuspect
            // 
            this.LabelTodaySuspect.AutoSize = true;
            this.LabelTodaySuspect.Location = new System.Drawing.Point(79, 68);
            this.LabelTodaySuspect.Name = "LabelTodaySuspect";
            this.LabelTodaySuspect.Size = new System.Drawing.Size(55, 15);
            this.LabelTodaySuspect.TabIndex = 20;
            this.LabelTodaySuspect.Text = "label6";
            // 
            // LabelTodayConfirmed
            // 
            this.LabelTodayConfirmed.AutoSize = true;
            this.LabelTodayConfirmed.Location = new System.Drawing.Point(3, 68);
            this.LabelTodayConfirmed.Name = "LabelTodayConfirmed";
            this.LabelTodayConfirmed.Size = new System.Drawing.Size(55, 15);
            this.LabelTodayConfirmed.TabIndex = 19;
            this.LabelTodayConfirmed.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "死亡";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "疑似";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "确诊";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "今日新增";
            // 
            // PlagueKnowledge
            // 
            this.PlagueKnowledge.Controls.Add(this.button2);
            this.PlagueKnowledge.Controls.Add(this.button1);
            this.PlagueKnowledge.Controls.Add(this.textBox1);
            this.PlagueKnowledge.Controls.Add(this.label8);
            this.PlagueKnowledge.Location = new System.Drawing.Point(1331, 502);
            this.PlagueKnowledge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlagueKnowledge.Name = "PlagueKnowledge";
            this.PlagueKnowledge.Size = new System.Drawing.Size(356, 490);
            this.PlagueKnowledge.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 356);
            this.textBox1.TabIndex = 26;
            // 
            // ProvinceRank
            // 
            this.ProvinceRank.Controls.Add(this.DataGridView);
            this.ProvinceRank.Controls.Add(this.label5);
            this.ProvinceRank.Location = new System.Drawing.Point(32, 194);
            this.ProvinceRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProvinceRank.Name = "ProvinceRank";
            this.ProvinceRank.Size = new System.Drawing.Size(447, 465);
            this.ProvinceRank.TabIndex = 27;
            this.ProvinceRank.Paint += new System.Windows.Forms.PaintEventHandler(this.ProvinceRank_Paint);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.province,
            this.confirmed,
            this.suspect,
            this.death});
            this.DataGridView.Location = new System.Drawing.Point(0, 50);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView.Size = new System.Drawing.Size(447, 418);
            this.DataGridView.TabIndex = 18;
            // 
            // province
            // 
            this.province.HeaderText = "省份";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Width = 75;
            // 
            // confirmed
            // 
            this.confirmed.HeaderText = "确诊";
            this.confirmed.MinimumWidth = 6;
            this.confirmed.Name = "confirmed";
            this.confirmed.ReadOnly = true;
            this.confirmed.Width = 75;
            // 
            // suspect
            // 
            this.suspect.HeaderText = "疑似";
            this.suspect.MinimumWidth = 6;
            this.suspect.Name = "suspect";
            this.suspect.ReadOnly = true;
            this.suspect.Width = 75;
            // 
            // death
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.death.DefaultCellStyle = dataGridViewCellStyle4;
            this.death.HeaderText = "死亡";
            this.death.MinimumWidth = 6;
            this.death.Name = "death";
            this.death.ReadOnly = true;
            this.death.Width = 75;
            // 
            // PlagueMap
            // 
            this.PlagueMap.Controls.Add(this.pictureBox1);
            this.PlagueMap.Location = new System.Drawing.Point(487, 12);
            this.PlagueMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlagueMap.Name = "PlagueMap";
            this.PlagueMap.Size = new System.Drawing.Size(835, 646);
            this.PlagueMap.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoV2019MIS.Properties.Resources.地图;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PlagueNews
            // 
            this.PlagueNews.Controls.Add(this.label6);
            this.PlagueNews.Controls.Add(this.listBox1);
            this.PlagueNews.Location = new System.Drawing.Point(1331, 12);
            this.PlagueNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlagueNews.Name = "PlagueNews";
            this.PlagueNews.Size = new System.Drawing.Size(351, 482);
            this.PlagueNews.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "最新新闻";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(-3, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 394);
            this.listBox1.TabIndex = 21;
            // 
            // HistoryChart
            // 
            this.HistoryChart.Controls.Add(this.label7);
            this.HistoryChart.Controls.Add(this.chart1);
            this.HistoryChart.Location = new System.Drawing.Point(16, 691);
            this.HistoryChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HistoryChart.Name = "HistoryChart";
            this.HistoryChart.Size = new System.Drawing.Size(1307, 302);
            this.HistoryChart.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "全国病例统计";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 40);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1259, 258);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1696, 1008);
            this.Controls.Add(this.HistoryChart);
            this.Controls.Add(this.PlagueNews);
            this.Controls.Add(this.PlagueMap);
            this.Controls.Add(this.ProvinceRank);
            this.Controls.Add(this.PlagueKnowledge);
            this.Controls.Add(this.OverAllInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.OverAllInfo.ResumeLayout(false);
            this.OverAllInfo.PerformLayout();
            this.PlagueKnowledge.ResumeLayout(false);
            this.PlagueKnowledge.PerformLayout();
            this.ProvinceRank.ResumeLayout(false);
            this.ProvinceRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PlagueMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlagueNews.ResumeLayout(false);
            this.PlagueNews.PerformLayout();
            this.HistoryChart.ResumeLayout(false);
            this.HistoryChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel OverAllInfo;
        private System.Windows.Forms.Label LabelSumDeath;
        private System.Windows.Forms.Label LabelSumSuspect;
        private System.Windows.Forms.Label LabelSumConfirmed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelTodayDeath;
        private System.Windows.Forms.Label LabelTodaySuspect;
        private System.Windows.Forms.Label LabelTodayConfirmed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PlagueKnowledge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel ProvinceRank;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspect;
        private System.Windows.Forms.DataGridViewTextBoxColumn death;
        private System.Windows.Forms.Panel PlagueMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PlagueNews;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel HistoryChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

