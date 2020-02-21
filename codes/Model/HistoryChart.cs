using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Model
{
    public class HistoryChart
    {
        private Chart historyChart;
        public HistoryChart(List<DailyData> data,Chart historyChart)
        {
            this.historyChart = historyChart;
            foreach(var day in data)
            {
                this.historyChart.Series["确诊人数"].Points.AddXY(day.date,day.confirmed.ToString());
                this.historyChart.Series["疑似病例"].Points.AddXY(day.date, day.suspect.ToString());
                this.historyChart.Series["死亡人数"].Points.AddXY(day.date, day.death.ToString());
            }
        }
    }
}
