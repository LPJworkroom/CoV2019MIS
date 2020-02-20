using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Convert;

namespace Model
{
    public class Overallinfo
    {
        /*Label控件集合，下标顺序分别为确诊、死亡、疑似*/
        private Label[] today; //今日新增
        private Label[] sum;   //累计概况

        /*设置所有信息*/
        void set(int[] data) { }
        public Overallinfo(Label[] today,Label[] sum,int[] todayData,int[] sumData)
        {
            this.today = today;
            this.sum = sum;
            for (int i = 0; i < 3; i++)
            {
                this.today[i].Text =todayData[i].ToString();
                this.sum[i].Text = sumData[i].ToString();
            }
        }
    }

}
