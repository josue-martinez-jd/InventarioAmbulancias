using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BuscarEquipo
/// </summary>
public class BuscarEquipo:Buscar
{
    public BuscarEquipo()
    {
    }

    //Polimorfismo
    public override string encuentra(string tipo)
    {
        string EquipoEncontrado = "";
        if (tipo == "Medicamento")
        {
            EquipoEncontrado = String.Join(", ", InicializarInventario.InventarioMedicamentoAmpolla) + "\n" + String.Join(", ", InicializarInventario.InventarioMedicamentoParo) + "\n" + String.Join(", ", InicializarInventario.InventarioMedicamentoSuero);
        }
        else if (tipo == "Herramienta")
        {
            EquipoEncontrado = String.Join(", ", InicializarInventario.InventarioHerramientaEstabilizador) + "\n" + String.Join(", ", InicializarInventario.InventarioHerramientaIntubacion) + "\n" + String.Join(", ", InicializarInventario.InventarioHerramientaOxigeno);
        }
        else if (tipo == "all")
        {
            EquipoEncontrado = String.Join(", ", InicializarInventario.InventarioHerramientaEstabilizador) + "\n" + String.Join(", ", InicializarInventario.InventarioHerramientaIntubacion) + "\n" + String.Join(", ", InicializarInventario.InventarioHerramientaOxigeno)
                + String.Join(", ", InicializarInventario.InventarioMedicamentoAmpolla) + "\n" + String.Join(", ", InicializarInventario.InventarioMedicamentoParo) + "\n" + String.Join(", ", InicializarInventario.InventarioMedicamentoSuero);
        }
        else { EquipoEncontrado = "No existe"; }

        return EquipoEncontrado;
    }
}