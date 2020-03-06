using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoASP
{
    public partial class _Default : Page
    {

        private int conteo = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (ViewState["click"]!=null)
            {
                conteo = (int)ViewState["click"] + 1;
            }
            
            txtConteo.Text = conteo.ToString();

            ViewState["click"] = conteo;
        }
    }
}