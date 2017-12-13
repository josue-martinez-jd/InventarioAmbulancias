using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Medicamento
/// </summary>
public class MedicamentoAmpolla:Equipo
{
    

    //Herencia
    public MedicamentoAmpolla(
        
        string pNombre, int pCant)
        :base(pNombre,  pCant)
    {

    }

    public MedicamentoAmpolla() { }

    //Polimorfismo
    public override void TipoEquipo()
    {
            Tipo= "Medicamento";
    }

    public override void CategoriaEquipo()
    {
           Categoria = "Ampolla";
    }

    public override void agregarEquipo( string nombreEquipo, int cantidadEquipo)
    {

        
        foreach (Historial item in DataBase.HistorialList)
        {
            if (item.Id == DataBase.HistorialList.Count)
            {
                foreach (MedicamentoAmpolla med in DataBase.InventarioMedicamentoAmpolla)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;

                        med.Cant = cantidadEquipo;
                        item.MedicamentoAmpollaList.Add(med);

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
                item.MedicamentoAmpollaList.Clear();

            }
        }
    }
}