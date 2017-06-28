using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ExampleWebService
{
    /// <summary>
    /// Summary description for ExampleWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ExampleWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        public String Hello(String nombre)
        {
            Session["nombre"] = nombre;
            return "Hola " + nombre;
        }

        [WebMethod(Description = "Este método trae la fecha")]
        public String getDate()
        {
            return DateTime.Today.ToString();
        }

    }
}
