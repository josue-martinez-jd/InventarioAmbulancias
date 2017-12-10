using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Print
/// </summary>
public class Print
{
    public static string printHistorialList()
    {
        return String.Join(", ", Historial.HistorialList);
    } 
}