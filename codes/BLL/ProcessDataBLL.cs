using Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ProcessDataBLL : IProcessDataBLL
    {
        public bool ProcessNewsData(string jstr)
        {
            JObject jnlst = JObject.Parse(jstr);
            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine(jnlst["results"].GetType());
            Console.WriteLine("//////////////////////////////////////////");
            bool res = false;
            foreach(var news in jnlst["results"])
            {
                
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
                // 当地时区
                double time = (double)news["pubDate"];
                DateTime dt = startTime.AddMilliseconds(time);
                //Console.WriteLine(dt.ToString("yyyy/MM/dd"));
                string date = dt.ToString("yyyy/MM/dd");
                string url = (string)news["sourceUrl"];
                string title = (string)news["title"];
                Console.WriteLine(date+" "+url+" "+title);
                Console.ReadLine();
                NewsData nd = new NewsData(date,url,title);//date,url,title
                INewsDataBLL ndb = new NewsDataBLL();
                res=ndb.insert(nd);
            }
            
            //Console.WriteLine(jnlst["results"]);
            //Console.ReadLine();
            return res;
        }

        public bool ProcessPlagueData(string jstr)
        {
            bool res = false;
            JObject jnlst = JObject.Parse(jstr);
            List<string> existDate=new List<string>();
            
            ProvinceSumData psd = new ProvinceSumData("",0,0,0);

            IProvinceDailyDataBLL pddbll = new ProvinceDailyDataBLL();
            IProvinceSumDataBLL psdbll = new ProvinceSumDataBLL();

            foreach (JObject pdinfo in jnlst["results"])//province daily info
            {
              
                //province
                string province = (string)pdinfo["provinceName"];
                //date
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
                double time = (double)pdinfo["updateTime"];
                DateTime dt = startTime.AddMilliseconds(time);
                string date = dt.ToString("yyyy-MM-dd");
                if (existDate.Contains(date))
                {
                    continue;
                }
                existDate.Add(date);

                int confirmed = 0, suspect = 0, death = 0;

                JObject judge = JObject.Parse("{\"error\": null}");

                if (pdinfo.Property("confirmedCount") != null && pdinfo.Property("confirmedCount").ToString() != ""&& !pdinfo["confirmedCount"].Equals(judge["error"]))
                    confirmed = (int)pdinfo["confirmedCount"];
                if (pdinfo.Property("suspectedCount") != null && pdinfo.Property("suspectedCount").ToString() != ""&& !pdinfo["suspectedCount"].Equals(judge["error"]))
                    suspect = (int)pdinfo["suspectedCount"];
                if (pdinfo.Property("deadCount") != null && pdinfo.Property("deadCount").ToString() != ""&& !pdinfo["deadCount"].Equals(judge["error"]))
                    death = (int)pdinfo["deadCount"];
                

                
                //Console.WriteLine(province+" "+date+" "+confirmed+" "+suspect+" "+death);
                //Console.ReadLine();
                //构建ProvinceDailyData类
                ProvinceDailyData pdd = new ProvinceDailyData(province,date,confirmed,suspect,death);
                //插入数据库
                if (pddbll.insert(pdd) == false)
                {
                    res=pddbll.update(pdd);
                    if (res == false)
                    {
                        return res;
                    }
                }

                //更新psd的值
                psd.province = province;
                psd.confirmed = Math.Max(psd.confirmed, pdd.confirmed);
                psd.suspect = Math.Max(psd.suspect, pdd.suspect);
                psd.death = Math.Max(psd.death, pdd.death);

            }

            Console.WriteLine("psd " + psd.province + " " + psd.confirmed + " " + psd.suspect + " " + psd.death);
            Console.ReadLine();
            if (psdbll.insert(psd)==false)
            {
                res=psdbll.update(psd);
                if (res == false)
                {
                    return res;
                }
            }
            
            return res;
        }
    }
}
