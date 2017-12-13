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
    public HerramientaIntubacion(
        string pNombre, int pCant)
        :base( pNombre,  pCant)
    {

    }

    public HerramientaIntubacion() { }

    //Polimorfismo
    public override void TipoEquipo()
    {
        Tipo = "Herramienta";
    }

    public override void CategoriaEquipo()
    {
        Categoria = "Intubacion";

    }

    public override void agregarEquipo( string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in DataBase.HistorialList)
        {
            if (item.Id == DataBase.HistorialList.Count)
            {

                foreach (HerramientaIntubacion med in DataBase.InventarioHerramientaIntubacion)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;

                        med.Cant = cantidadEquipo;
                        item.HerramientaIntubacionList.Add(med);

                        med.Cant = cantMedicamentoMax - cantidadEquipo;

                    }
                }
            }
        }
    }

    public override void descartarEquipo()
    {
        foreach (Historial item in DataBase.HistorialList)
        {
            if (item.Id == DataBase.HistorialList.Count)
            {
                item.HerramientaIntubacionList.Clear();

            }
        }
    }
}