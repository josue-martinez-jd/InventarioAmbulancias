using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HistorialCrear
/// </summary>
public class HistorialCrear
{
    public HistorialCrear() { }

    public void createEmpyHistory()//Crea una nueva lista vacia con solamente el ID (agregado automaticamente) y el valor de "Submitted" en false
    {
        HistorialEstado estado = new HistorialEstado();
        if (InicializarInventario.HistorialList.Count > 0)
        {
            if (estado.HistorialSubmitted() == true)
            {
                Historial newHistorial = new Historial((InicializarInventario.HistorialList.Count + 1), false);
                InicializarInventario.HistorialList.Add(newHistorial);
            }
        }
        else
        {
            Historial newHistorial = new Historial(1, false);
            InicializarInventario.HistorialList.Add(newHistorial);
        }
    }
}