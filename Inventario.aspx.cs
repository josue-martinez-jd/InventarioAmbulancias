using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drpInventarioTipo.Items.Add("Medicamento");
            drpInventarioTipo.Items.Add("Herramienta");

        }
    }

    protected void btnBuscarInventario_Click(object sender, EventArgs e)
    {
        BuscarEquipo equipo = new BuscarEquipo();
        txaHistorial.Value= equipo.encuentra(drpInventarioTipo.SelectedItem.Text);

    }

    protected void btnBuscarTodoInventario_Click(object sender, EventArgs e)
    {
        BuscarEquipo equipo = new BuscarEquipo();
        txaHistorial.Value = equipo.encuentra("all");
    }
}