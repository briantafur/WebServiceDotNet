using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceConsumer
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void obtenerFecha(Object sender, EventArgs e)
        {
            ServiceReference1.ExampleWSSoapClient webService = new ServiceReference1.ExampleWSSoapClient();
            Label2.Text = webService.getDate();
        }

        protected void helloWorld(Object sender, EventArgs e)
        {
            ServiceReference1.ExampleWSSoapClient webService = new ServiceReference1.ExampleWSSoapClient();
            Label1.Text = webService.HelloWorld();
        }

        protected void hello(Object sender, EventArgs e)
        {
            String nombre = TextBox1.Text;
            ServiceReference1.ExampleWSSoapClient webService = new ServiceReference1.ExampleWSSoapClient();
            Label3.Text = webService.Hello(nombre);
        }

    }
}