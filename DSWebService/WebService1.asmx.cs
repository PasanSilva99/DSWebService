using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace DSWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtPhones = new DataTable();

        [WebMethod]
        public string MobilePhones()
        {
            dtPhones.Columns.Add("Pone");
            dtPhones.Columns.Add("Price");

            dtPhones.Rows.Add("Samsung", "1000");
            dtPhones.Rows.Add("iPhone", "1500");
            dtPhones.Rows.Add("Nokia", "700");

            var vtable = JsonConvert.SerializeObject(dtPhones);

            return vtable.ToString();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double AddNumber(double n1, double n2)
        {
            return n1 + n2;
        }

        [WebMethod]
        public string Welcome(string Name)
        {
            return Name;
        }
    }
}
