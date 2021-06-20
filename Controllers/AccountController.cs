using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using simpalapilearn.BLL;
using simpalapilearn.MLL;

namespace simpalapilearn.Controllers
{
    [Route("api/[controller]/{action}/{id?}/{id2?}")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        AccountBLL accountBLL;
        public AccountController()
        {
            accountBLL = new AccountBLL();
        }

        [HttpGet]
        public async Task<Response<IEnumerable<AccountInfoModel>>> GetAccount(int id)
        {

            Response<IEnumerable<AccountInfoModel>> returnobj = new Response<IEnumerable<AccountInfoModel>>();
            returnobj.Message = new List<string>();
            try
            {
                returnobj.Data = await accountBLL.GetAccount(id);

            }
            catch (Exception ex)
            {

            }
            return returnobj;

        }

        [HttpPost]

        public async Task<Response<IEnumerable<AccountInfoModel>>> GetCmpDate(AccountInfoModel model)
        {
            Response<IEnumerable<AccountInfoModel>> retobj = new Response<IEnumerable<AccountInfoModel>>();
            retobj.Message = new List<string>();
            try
            {
                 //= new AccountInfoModel();
                retobj.Data = await accountBLL.GetCmpData(model);
            }
            catch (Exception ex)
            {

               
            }
            return retobj;
        }

        [HttpGet]
        public async Task<Response<IEnumerable<AccountInfoModel>>> twoparammethod(int id,int id2)
        {
            Response<IEnumerable<AccountInfoModel>> modobj = new Response<IEnumerable<AccountInfoModel>>();

            try
            {
                modobj.Data = await accountBLL.TwoParamMwthod(id, id2);
            }
            catch (Exception)
            {

                throw;
            }
            return modobj;
        }
    }
}