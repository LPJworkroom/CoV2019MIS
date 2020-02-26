using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BLL
{
    public class UpdateDataBLL : IUpdateDataBLL
    {
        public bool updateNews()
        {
            CatchJsonBLL cjb = new CatchJsonBLL();
            string res = cjb.catchjson("https://lab.isaaclin.cn/nCoV/api/news");//新闻测试

            //MessageBox.Show(res);
            ProcessDataBLL pdb = new ProcessDataBLL();
            return pdb.ProcessNewsData(res);
        }

        public bool updatePlague()
        {
            bool res = false;
            //查询所有省
            IProvinceSumDataBLL psdbll = new ProvinceSumDataBLL();
            List<ProvinceSumData> psdlst = psdbll.selectALL();
            Form f = new Form();
            f.Height = 0;
            f.Width = 400;
            f.Text = "";
            f.Show();
            for (int i=0;i<psdlst.Count;i++)
            {
                f.Text =String.Format("更新中，已完成：{0}/{1}",i,psdlst.Count);
                var psd = psdlst[i];
                Thread.Sleep(500);
                string province = psd.province;
                CatchJsonBLL cjb = new CatchJsonBLL();
                string url = "https://lab.isaaclin.cn/nCoV/api/area?latest=0&province=" + province;
                string jstr = cjb.catchjson(url);//新闻测试
                
                //MessageBox.Show(jstr);
                ProcessDataBLL pdb = new ProcessDataBLL();
                res=pdb.ProcessPlagueData(jstr);
                
            }
            f.Hide();
            return res;
            
        }
    }
}
