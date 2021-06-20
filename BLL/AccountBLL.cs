using Newtonsoft.Json;
using simpalapilearn.DLL;
using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.BLL
{
    public class AccountBLL
    {
        IAccountRepo db;
        public AccountBLL()
        {
           db=new AccountRepo();
            db = new AccountRepo();
            db = new AccountRepo();
            // datatable db = "santosh";
        }

        public Task<IEnumerable<AccountInfoModel>> GetAccount(int id)
        {
            //var a= db.GetAccount(id);
            return db.GetAccount(id);
        }

        public Task<IEnumerable<AccountInfoModel>> GetCmpData(AccountInfoModel model)
        {
            return db.GetCmpWiseDate(model.AccountLedger_ID, model.AccountLedger_CompanyId);
        }
      

        public Task<IEnumerable<AccountInfoModel>>TwoParamMwthod(int a,int b)
        {
            return db.TwoParameterMethod(a, b);
        }

       
    }
}
