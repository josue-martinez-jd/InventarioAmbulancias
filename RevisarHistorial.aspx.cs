using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RevisarHistorial : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBuscarHistorial_Click(object sender, EventArgs e)
    {
        BuscarHistorial historial = new BuscarHistorial();
        txaHistorial.Value = historial.encuentra(txtCedula.Text);

    }
}