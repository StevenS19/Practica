using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoASP
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Cantidad de aplicaciones instanciadas"+ Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario" + Application["SesionesUsuario"]);
        }
    }
}