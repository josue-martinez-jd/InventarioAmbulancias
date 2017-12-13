using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Equipo
/// </summary>
public class HerramientaEstabilizador : Equipo
{
    //Herencia
    public HerramientaEstabilizador(string pNombre, int pCant):base( pNombre,  pCant){  }

    public HerramientaEstabilizador() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo = "Herramienta"; }

    public override void CategoriaEquipo()
    { Categoria = "Estabilizador"; }

    public override void agregarEquipo(string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (HerramientaEstabilizador med in InicializarInventario.InventarioHerramientaEstabilizador)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;
                        med.Cant = cantidadEquipo;
                        item.HerramientaEstabilizadorList.Add(med);

                        if(med.Cant== cantidadEquipo)
                        { med.Cant = cantMedicamentoMax - cantidadEquipo; }
                    }
                }
            }
        }
    }

    public override void descartarEquipo()
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            { item.HerramientaEstabilizadorList.Clear(); }
        }
    }
}