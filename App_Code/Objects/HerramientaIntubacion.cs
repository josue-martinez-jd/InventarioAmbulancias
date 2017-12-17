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
                foreach (HerramientaIntubacion herramienta in InicializarInventario.InventarioHerramientaIntubacion)
                {
                    if (herramienta.Nombre == nombreEquipo)
                    {
                        herramienta.Cant = herramienta.Cant - cantidadEquipo;
                        item.HerramientaIntubacionList.Add(herramienta);
                    }
                }
            }
        }
    }
}