using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HistorialEstado
/// </summary>
public class HistorialEstado
{
    public HistorialEstado() { }

    public Boolean HistorialSubmitted()
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count())
            {
                if (item.Submitted == true)
                {
                    return true;
                }
            }
        }
        return false;
    }
}