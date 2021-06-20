using Newtonsoft.Json;
using simpalapilearn.DLL;
using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.BLL
{
    public class CityBll
    {
        ICityRepo Db;
        public CityBll()
        {
            Db = new CityRepo();
           Dl = new CityRepo();
        }
         public string InsertCity( ref Cityinfomodel Citym)
        {
           
            return Db.InserCity(Citym);
         
        }

        public bool InsertAllCity(ref Cityinfomodel CityInfo)
        {
            try
            {
                var obj = JsonConvert.SerializeObject(CityInfo);
                var robj = Db.InsertAllCity(obj);

                robj = robj.Replace("\\","");
                robj = robj.Trim('[');
                robj = robj.Trim(']');
                robj = robj.Trim('"');
                robj = robj.Replace("\"{", "{");
                robj = robj.Replace("}\"", "}");
                var retobj = JsonConvert.DeserializeObject<SqlResponce<Cityinfomodel>>(robj);
                //if (retobj.City_ID == 0)
                //{

                //}
                //else
                //{
                //    CityInfo = retobj.fulldata;
                //}

            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

    }
}
