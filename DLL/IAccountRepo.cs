using simpalapilearn.MLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.DLL
{
    public interface IAccountRepo
    {
        Task<IEnumerable<AccountInfoModel>> GetAccount(int id);
        Task<IEnumerable<AccountInfoModel>> GetCmpWiseDate(int Id, int CId);
        Task<IEnumerable<AccountInfoModel>> TwoParameterMethod(int a, int b);
    }
}
