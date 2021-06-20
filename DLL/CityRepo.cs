using Dapper;
using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.DLL
{
    public class CityRepo:ConnectionString,ICityRepo
    {

   
        public string InserCity(Cityinfomodel cityd1 )

        {

            return IDBCON.QueryFirstOrDefault<string>("SPCity", new { city = cityd }, commandType: CommandType.StoredProcedure);
  
        }

        public string  InsertAllCity(string jsondata)
        {
            try
            {
                return IDBCON.QueryFirstOrDefault<string>("SpInsertCity", new { CityJson = jsondata }, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
