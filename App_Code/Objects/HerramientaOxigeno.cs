using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HerramientaOxigeno
/// </summary>
public class HerramientaOxigeno : Equipo
{
    //Herencia
    public HerramientaOxigeno( string pNombre, int pCant):base( pNombre,  pCant) { }

    public HerramientaOxigeno() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo = "Herramienta"; }

    public override void CategoriaEquipo()
    { Categoria = "Oxigeno"; }

    public override void agregarEquipo( string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (HerramientaOxigeno med in InicializarInventario.InventarioHerramientaOxigeno)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;
                        med.Cant = cantidadEquipo;
                        item.HerramientaOxigenoList.Add(med);

                        if (med.Cant == cantidadEquipo)
                        { med.Cant = cantMedicamentoMax - cantidadEquipo; }
                    }
                }
            }
        }
    }
}