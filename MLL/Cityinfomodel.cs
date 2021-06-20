using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.MLL
{
    public class Cityinfomodel
    {
        public int City_ID { get; set; }
        public string City_Name { get; set; }
        public string City_StateName { get; set; }
        public string City_Status { get; set; }
        public int City_CompanyId { get; set; }
        public int City_PosId { get; set; }
        public DateTime City_ExtraDate { get; set; }
        public bool City_IsDelete { get; set; }
        public int City_Createdby { get; set; }
        public DateTime City_CreatedDate { get; set; }
        public int City_ModifiedBy { get; set; }
        public DateTime City_ModifiedDate { get; set; }

    }
}
