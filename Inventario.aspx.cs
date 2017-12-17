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
        try {
            BuscarEquipo equipo = new BuscarEquipo();
            txaHistorial.Value = equipo.encuentra(drpInventarioTipo.SelectedItem.Text);
        } catch(Exception h) { }
    }

    protected void btnBuscarTodoInventario_Click(object sender, EventArgs e)
    {
        try {
            BuscarEquipo equipo = new BuscarEquipo();
            txaHistorial.Value = equipo.encuentra("all");
        } catch(Exception h) { }
    }

    protected void btnLlenarInventario_Click(object sender, EventArgs e)
    {
        try {
            InicializarInventario inventario = new InicializarInventario();
            inventario.LlenarInventario();
            BuscarEquipo equipo = new BuscarEquipo();
            txaHistorial.Value = equipo.encuentra("all");
        } catch(Exception h) { }
    }
}