using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace simpalapilearn.DLL
{
    public class ConnectionString
    {

        protected IDbConnection IDBCON;

        public ConnectionString()
        {
           // IDBCON = new SqlConnection("Data Source=DESKTOP-9L3J39C\\SQLEXPRESS;Initial Catalog=RetailSoft;Integrated Security=true;");
            IDBCON = new SqlConnection ("Data Source=DESKTOP-9L3J39C\\SQLEXPRESS;Initial Catalog=RetailSoft;User ID=RSoft;Password=Reta!lS0ft@444;");
        }
        //Obj= "Server=(localdb)\\mssqllocaldb;Database=aspnet5-ConfigurationSample-ad90971f-6620-4bc1-ad28-650c59478cc1;Trusted_Connection=True;MultipleActiveResultSets=true"

    }
    
}
