using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dojo.Banco.Model;
using Dojo.Banco.Business;

namespace Dojo.Banco.Web.Pages
{
    public partial class ConsultaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void GetAll()
        {
            gdvClientes.DataSource = new ClienteBusiness().GetAll();
            gdvClientes.DataBind();
        }
    }
}