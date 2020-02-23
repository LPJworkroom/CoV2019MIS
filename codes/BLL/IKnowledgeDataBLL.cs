using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IKnowledgeDataBLL
    {
        List<KnowledgeData> selectALL();
        List<KnowledgeData> selectByType(string type);
        KnowledgeData selectByType_Title(string type, string title);
        bool insert(KnowledgeData kd);
        bool update(KnowledgeData kd);
    }
}
