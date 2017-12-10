using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Medicamento
/// </summary>
public class Medicamento:Atencion
{
  

    public Medicamento(
        string pCategoria, string pTipo, 
        string pNombre, int pCant)
        :base( 
            pCategoria,  pTipo,  
            pNombre,  pCant)
    {

    }

  
}