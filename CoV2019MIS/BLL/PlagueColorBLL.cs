using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class PlagueColorBLL : IPlagueColorBLL
    {
        private static IPlagueColorDAO pcdao = new PlagueColorDAO();
        public List<PlagueColor> selectALL()
        {
            return pcdao.selectALL();
        }

        public PlagueColor selectByNum(int num)
        {
            return pcdao.selectByNum(num);
        }
    }
}
