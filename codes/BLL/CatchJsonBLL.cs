using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BLL
{
    public class CatchJsonBLL : ICatchJsonBLL
    {
        public string catchjson(string url)
        {
            string content="";
            //"https://lab.isaaclin.cn/nCoV/api/area?latest=1&province=%E6%B9%96%E5%8C%97%E7%9C%81"
            HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
            if (httpWebResponse != null)
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    content = sr.ReadToEnd();
                }
                httpWebResponse.Close();
            }
            return content;
        }
    }
}
