using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BuscarHistorial
/// </summary>
public class BuscarHistorial : Buscar
{
    public BuscarHistorial()
    {
    }

    public override string encuentra(string cedula)
    {
        string historialString = "No existe";
        try
        {
            List<Historial> historialEncontrado = new List<Historial>();
            foreach (Historial item in InicializarInventario.HistorialList)
            {
                if (item.Cedula == Int32.Parse(cedula))
                {
                    historialEncontrado.Add(item);
                    historialString = String.Join(", ", historialEncontrado);
                }
            }
            return historialString;
        }
        catch (Exception h) { return historialString; }
    }
}