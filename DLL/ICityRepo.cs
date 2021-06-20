using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.DLL
{
    public interface ICityRepo
    {
        string InserCity(Cityinfomodel cityd);
        string InsertAllCity(string jsondata);
    }

}
