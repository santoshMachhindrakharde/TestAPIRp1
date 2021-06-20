using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.MLL
{
    public class Response<T>
    {
        public string IsError { get; set; }
        public string ErrorCode { get; set; }
        public List<string> Message { get; set; }
        public T Data { get; set; }
    }
     public class SqlResponce<T>
    {
        public int id { get; set; }
           
        public T fulldata { get; set; }

        public string Errormsg { get; set; }

    }
}
