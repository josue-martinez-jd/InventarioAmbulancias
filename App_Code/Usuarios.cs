using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Usuarios
/// </summary>
public static class Usuarios
{
    static Boolean _logged; 

    public static Boolean IsLogged
    {
        get
        {
            return _logged;
        }
        set
        {
            _logged = value; 
        }
    }
}