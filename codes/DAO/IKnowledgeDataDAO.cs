using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public interface IKnowledgeDataDAO
    {
        List<KnowledgeData> selectALL();
        List<KnowledgeData> selectByType(string type);
        KnowledgeData selectByType_Title(string type,string title);
        int insert(KnowledgeData kd);
        int update(KnowledgeData kd);
    }
}
