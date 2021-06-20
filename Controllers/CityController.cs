using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpalapilearn.BLL;
using simpalapilearn.MLL;

namespace simpalapilearn.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    [ApiController]
    public class CityController : ControllerBase
    {
        CityBll cityBll;

        public CityController()
        {
            cityBll = new CityBll();
        }
        [HttpPost]

        public Response<Cityinfomodel>SpInsertCity(Cityinfomodel Cityinfo)
        {
            Response<Cityinfomodel> WinOnj = new Response<Cityinfomodel>();
            WinOnj.Message = new List<string>();
            try
            {
                if(cityBll.InsertAllCity(ref Cityinfo))
                {
                    WinOnj.Data = Cityinfo;
                    WinOnj.Message.Add ( "Insert Success");
                }
                else
                {
                    WinOnj.Data = null;
                    WinOnj.Message.Add("Insert fail");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return WinOnj;
        }
    }
}