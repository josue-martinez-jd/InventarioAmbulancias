using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Atencion
/// </summary>
public class Equipo
{
    private string _Categoria;
    private string _Tipo;
    private string _Nombre;
    private int _Cant;
 
    public Equipo(string pNombre, int pCant)
    {
        Nombre = pNombre;
        Cant = pCant; 
    }

    public Equipo() { }

    //Sets & Gets
    //Tell don't ask
    public string Categoria{ get{return _Categoria; }
        set { if (value != "") { _Categoria = value; } }
    }

    public string Tipo { get { return _Tipo; }
        set { if (value != "") { _Tipo = value; }  }
    }

    public string Nombre { get { return _Nombre; }
        set { if (value!="") { _Nombre = value; } }
    }

    public int Cant { get { return _Cant; }
        set { if (value >= 0) { _Cant = value; } }
    }

    public override string ToString()
    {
        return "\n Tipo: "+_Tipo+ ", Categoria: " + _Categoria + ", Nombre: " +_Nombre+", Cantidad: "+_Cant+"";
    }

    //Polimorfismo
    public virtual void TipoEquipo() { }

    public virtual void CategoriaEquipo() { }

    public virtual void agregarEquipo(string nombreEquipo, int cantidadEquipo) { }
}