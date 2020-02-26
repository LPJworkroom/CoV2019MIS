namespace CoV2019MIS
{
    partial class 疫情信息管理系统
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
            System.Windows.Forms.DataVisualization.Charting.Chart chart1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OverAllInfo = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSumDeath = new System.Windows.Forms.Label();
            this.labelSumSuspect = new System.Windows.Forms.Label();
            this.labelSumConfirmed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PlagueKnowledge = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProvinceRankPanel = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlagueNews = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HistoryChart = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(chart1)).BeginInit();
            this.OverAllInfo.SuspendLayout();
            this.PlagueKnowledge.SuspendLayout();
            this.ProvinceRankPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PlagueNews.SuspendLayout();
            this.HistoryChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorGrid.LineWidth = 2;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "确诊";
            chart1.Legends.Add(legend2);
            chart1.Location = new System.Drawing.Point(13, 32);
            chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Coral,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.OrangeRed};
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "确诊";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerBorderWidth = 0;
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "新增确诊";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.BorderWidth = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "确诊";
            series5.MarkerBorderColor = System.Drawing.Color.Black;
            series5.MarkerBorderWidth = 0;
            series5.MarkerSize = 7;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "疑似病例";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "确诊";
            series6.MarkerBorderWidth = 0;
            series6.Name = "死亡人数";
            chart1.Series.Add(series4);
            chart1.Series.Add(series5);
            chart1.Series.Add(series6);
            chart1.Size = new System.Drawing.Size(1275, 242);
            chart1.TabIndex = 25;
            chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(-3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "省份排名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "你知道吗？";
            // 
            // OverAllInfo
            // 
            this.OverAllInfo.Controls.Add(this.label15);
            this.OverAllInfo.Controls.Add(this.labelSumDeath);
            this.OverAllInfo.Controls.Add(this.labelSumSuspect);
            this.OverAllInfo.Controls.Add(this.labelSumConfirmed);
            this.OverAllInfo.Controls.Add(this.label9);
            this.OverAllInfo.Controls.Add(this.label10);
            this.OverAllInfo.Controls.Add(this.label11);
            this.OverAllInfo.Location = new System.Drawing.Point(16, 12);
            this.OverAllInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OverAllInfo.Name = "OverAllInfo";
            this.OverAllInfo.Size = new System.Drawing.Size(481, 159);
            this.OverAllInfo.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(35, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 33);
            this.label15.TabIndex = 31;
            this.label15.Text = "全国总计";
            // 
            // labelSumDeath
            // 
            this.labelSumDeath.AutoSize = true;
            this.labelSumDeath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelSumDeath.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelSumDeath.Location = new System.Drawing.Point(345, 62);
            this.labelSumDeath.Name = "labelSumDeath";
            this.labelSumDeath.Size = new System.Drawing.Size(73, 27);
            this.labelSumDeath.TabIndex = 30;
            this.labelSumDeath.Text = "label5";
            // 
            // labelSumSuspect
            // 
            this.labelSumSuspect.AutoSize = true;
            this.labelSumSuspect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelSumSuspect.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelSumSuspect.Location = new System.Drawing.Point(199, 62);
            this.labelSumSuspect.Name = "labelSumSuspect";
            this.labelSumSuspect.Size = new System.Drawing.Size(73, 27);
            this.labelSumSuspect.TabIndex = 29;
            this.labelSumSuspect.Text = "label5";
            // 
            // labelSumConfirmed
            // 
            this.labelSumConfirmed.AutoSize = true;
            this.labelSumConfirmed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelSumConfirmed.ForeColor = System.Drawing.Color.Coral;
            this.labelSumConfirmed.Location = new System.Drawing.Point(47, 62);
            this.labelSumConfirmed.Name = "labelSumConfirmed";
            this.labelSumConfirmed.Size = new System.Drawing.Size(73, 27);
            this.labelSumConfirmed.TabIndex = 28;
            this.labelSumConfirmed.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(347, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "死亡";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(201, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "疑似";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(51, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "确诊";
            // 
            // PlagueKnowledge
            // 
            this.PlagueKnowledge.Controls.Add(this.button3);
            this.PlagueKnowledge.Controls.Add(this.richTextBox1);
            this.PlagueKnowledge.Controls.Add(this.label14);
            this.PlagueKnowledge.Controls.Add(this.label13);
            this.PlagueKnowledge.Controls.Add(this.button2);
            this.PlagueKnowledge.Controls.Add(this.button1);
            this.PlagueKnowledge.Controls.Add(this.label8);
            this.PlagueKnowledge.Location = new System.Drawing.Point(1331, 504);
            this.PlagueKnowledge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlagueKnowledge.Name = "PlagueKnowledge";
            this.PlagueKnowledge.Size = new System.Drawing.Size(357, 490);
            this.PlagueKnowledge.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(103, 422);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "更新数据和新闻";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑 Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 84);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(343, 260);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(145, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 26);
            this.label14.TabIndex = 30;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(9, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "下一条";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "上一条";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProvinceRankPanel
            // 
            this.ProvinceRankPanel.Controls.Add(this.DataGridView);
            this.ProvinceRankPanel.Controls.Add(this.label5);
            this.ProvinceRankPanel.Location = new System.Drawing.Point(53, 198);
            this.ProvinceRankPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProvinceRankPanel.Name = "ProvinceRankPanel";
            this.ProvinceRankPanel.Size = new System.Drawing.Size(425, 465);
            this.ProvinceRankPanel.TabIndex = 27;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.province,
            this.confirmed,
            this.suspect,
            this.death});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView.GridColor = System.Drawing.Color.White;
            this.DataGridView.Location = new System.Drawing.Point(0, 50);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView.ShowCellErrors = false;
            this.DataGridView.ShowCellToolTips = false;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(447, 380);
            this.DataGridView.TabIndex = 18;
            this.DataGridView.Sorted += new System.EventHandler(this.DataGridView_Sorted);
            // 
            // province
            // 
            this.province.DataPropertyName = "String";
            this.province.HeaderText = "省份";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Width = 66;
            // 
            // confirmed
            // 
            this.confirmed.DataPropertyName = "Int";
            this.confirmed.HeaderText = "确诊";
            this.confirmed.MinimumWidth = 6;
            this.confirmed.Name = "confirmed";
            this.confirmed.ReadOnly = true;
            this.confirmed.Width = 66;
            // 
            // suspect
            // 
            this.suspect.DataPropertyName = "Int";
            this.suspect.HeaderText = "疑似";
            this.suspect.MinimumWidth = 6;
            this.suspect.Name = "suspect";
            this.suspect.ReadOnly = true;
            this.suspect.Width = 66;
            // 
            // death
            // 
            this.death.DataPropertyName = "Int";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.death.DefaultCellStyle = dataGridViewCellStyle8;
            this.death.HeaderText = "死亡";
            this.death.MinimumWidth = 6;
            this.death.Name = "death";
            this.death.ReadOnly = true;
            this.death.Width = 66;
            // 
            // PlagueNews
            // 
            this.PlagueNews.Controls.Add(this.label6);
            this.PlagueNews.Controls.Add(this.listBox1);
            this.PlagueNews.Location = new System.Drawing.Point(1331, 12);
            this.PlagueNews.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlagueNews.Name = "PlagueNews";
            this.PlagueNews.Size = new System.Drawing.Size(351, 482);
            this.PlagueNews.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(-7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "最新新闻";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(-3, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 351);
            this.listBox1.TabIndex = 21;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // HistoryChart
            // 
            this.HistoryChart.Controls.Add(chart1);
            this.HistoryChart.Controls.Add(this.label7);
            this.HistoryChart.Location = new System.Drawing.Point(16, 691);
            this.HistoryChart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HistoryChart.Name = "HistoryChart";
            this.HistoryChart.Size = new System.Drawing.Size(1307, 302);
            this.HistoryChart.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(31, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "全国病例统计";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(548, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "疫情地图";
            // 
            // 疫情信息管理系统
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1689, 1055);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HistoryChart);
            this.Controls.Add(this.PlagueNews);
            this.Controls.Add(this.ProvinceRankPanel);
            this.Controls.Add(this.PlagueKnowledge);
            this.Controls.Add(this.OverAllInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "疫情信息管理系统";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ShowIcon = false;
            this.Text = "疫情信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(chart1)).EndInit();
            this.OverAllInfo.ResumeLayout(false);
            this.OverAllInfo.PerformLayout();
            this.PlagueKnowledge.ResumeLayout(false);
            this.PlagueKnowledge.PerformLayout();
            this.ProvinceRankPanel.ResumeLayout(false);
            this.ProvinceRankPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PlagueNews.ResumeLayout(false);
            this.PlagueNews.PerformLayout();
            this.HistoryChart.ResumeLayout(false);
            this.HistoryChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel OverAllInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PlagueKnowledge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ProvinceRankPanel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PlagueNews;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel HistoryChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSumDeath;
        private System.Windows.Forms.Label labelSumSuspect;
        private System.Windows.Forms.Label labelSumConfirmed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspect;
        private System.Windows.Forms.DataGridViewTextBoxColumn death;
        private System.Windows.Forms.Button button3;
    }
}

