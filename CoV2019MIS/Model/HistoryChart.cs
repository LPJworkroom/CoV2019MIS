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
                var date = day.date;
                date= date.Remove(date.IndexOf(" "));
                date=date.Remove(0,5);

                this.historyChart.Series["新增确诊"].Points.AddXY(date,day.confirmed.ToString());
                this.historyChart.Series["疑似病例"].Points.AddXY(date, day.suspect.ToString());
                Console.WriteLine(day.suspect);
                this.historyChart.Series["死亡人数"].Points.AddXY(date, day.death.ToString());
            }
        }
    }
}
