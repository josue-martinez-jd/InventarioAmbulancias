using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MedicamentoSuero
/// </summary>
public class MedicamentoSuero:Equipo
{

    //Herencia
    public MedicamentoSuero(

        string pNombre, int pCant)
        :base(pNombre,  pCant)
    {

    }

    public MedicamentoSuero() { }

    //Polimorfismo
    public override void TipoEquipo()
    {
        Tipo = "Medicamento";
    }

    public override void CategoriaEquipo()
    {
        Categoria = "Suero";
    }

    public override void agregarEquipo(string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in DataBase.HistorialList)
        {
            if (item.Id == DataBase.HistorialList.Count)
            {
                foreach (MedicamentoSuero med in DataBase.InventarioMedicamentoSuero)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;

                        med.Cant = cantidadEquipo;
                        item.MedicamentoSueroList.Add(med);

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
                item.MedicamentoSueroList.Clear();

            }
        }
    }
}