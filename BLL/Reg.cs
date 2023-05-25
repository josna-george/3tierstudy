using System;
using DAL;

namespace BLL
{
    public class Reg
    {
        ConnectionCLS objdal = new ConnectionCLS();
        public int InsertDB(string na,int ag,string addr,string una,string pw)
        {
            string s = "insert into tab3t values('"+na+"','"+ag+"','"+addr+"','"+una+"','"+pw+"')";
            int i = objdal.Fun_Exenonquery(s);
            return i;
        }
    }
}
