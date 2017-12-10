using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Atencion
/// </summary>
public class Atencion
{

    private string _Categoria;
    private string _Tipo;
    private string _Nombre;
    private int _Cant;
 

    public Atencion(
        string pCategoria, string pTipo, 
        string pNombre, int pCant)
    {
        Categoria = pCategoria;
        Tipo = pTipo;
        Nombre = pNombre;
        Cant = pCant;
        
    }


    public string Categoria
    {  get{return _Categoria; } set{ _Categoria = value;} }

    public string Tipo
    { get { return _Tipo; } set { _Tipo = value; } }

    public string Nombre
    { get { return _Nombre; } set { _Nombre = value; } }

    public int Cant
    { get { return _Cant; } set { _Cant = value; } }

    public override string ToString()
    {
        return "Categoria: " +_Categoria+", Tipo: "+_Tipo+", Nombre: "+_Nombre+", Cantidad: "+_Cant+"";
    }

    

}