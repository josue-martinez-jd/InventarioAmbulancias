using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HerramientaIntubacion
/// </summary>
public class HerramientaIntubacion : Equipo
{
    //Herencia
    public HerramientaIntubacion(string pNombre, int pCant):base( pNombre,  pCant) { }

    public HerramientaIntubacion() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo = "Herramienta"; }

    public override void CategoriaEquipo()
    { Categoria = "Intubacion"; }

    public override void agregarEquipo( string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (HerramientaIntubacion med in InicializarInventario.InventarioHerramientaIntubacion)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;
                        med.Cant = cantidadEquipo;
                        item.HerramientaIntubacionList.Add(med);

                        if (med.Cant == cantidadEquipo)
                        { med.Cant = cantMedicamentoMax - cantidadEquipo; }
                    }
                }
            }
        }
    }
}