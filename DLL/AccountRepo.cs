using Dapper;
using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.DLL
{
    public class AccountRepo:ConnectionString,IAccountRepo
    {
        ////public 
        ///
       public Task<IEnumerable<AccountInfoModel>> GetAccount(int id)
        {
            try
            {
                //var as1 = IDBCON.QueryAsync<AccountInfoModel>("SpAccount", new { Id = id }, commandType: CommandType.StoredProcedure);
                return IDBCON.QueryAsync<AccountInfoModel>("SpAccount", new { Id = id }, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {

                throw;
            }
            }

        public Task<IEnumerable<AccountInfoModel>>GetCmpWiseDate(int Id,int CId)
        {
            try
            {
                return IDBCON.QueryAsync<AccountInfoModel>("SpAccountbyCmp", new { Id = Id, CId = CId }, commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<IEnumerable<AccountInfoModel>>TwoParameterMethod(int a,int b)
        {
            try
            {
                return IDBCON.QueryAsync<AccountInfoModel>("SpAccountbyCmp", new { Id = a, CId = b }, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex )
            {

                throw;
            }
        }
    }
}
