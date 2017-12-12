using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Equipo
/// </summary>
public class Equipo : Atencion
{


    public Equipo(
        string pCategoria, string pTipo, 
        string pNombre, int pCant)
        :base( 
            pCategoria,  pTipo,  
            pNombre,  pCant)
    {
        
    }

  

}