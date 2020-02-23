using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class KnowledgeDataBLL : IKnowledgeDataBLL
    {
        private static IKnowledgeDataDAO kddao = new KnowledgeDataDAO();
        public bool insert(KnowledgeData kd)
        {
            KnowledgeData existKd = kddao.selectByType_Title(kd.type,kd.title);
            if (existKd != null)
            {
                return false;
            }
            int line = kddao.insert(kd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }

        public List<KnowledgeData> selectALL()
        {
            return kddao.selectALL();
        }

        public List<KnowledgeData> selectByType(string type)
        {
            return kddao.selectByType(type);
        }

        public KnowledgeData selectByType_Title(string type, string title)
        {
            return kddao.selectByType_Title(type,title);
        }

        public bool update(KnowledgeData kd)
        {
            KnowledgeData existKd = kddao.selectByType_Title(kd.type, kd.title);
            if (existKd == null)
            {
                return false;
            }
            int line = kddao.update(kd);
            if (line == 1)
            {
                return true;
            }
            return false;
        }
    }
}
