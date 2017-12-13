using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MedicamentoParo
/// </summary>
public class MedicamentoParo : Equipo
{
    

    //Herencia
    public MedicamentoParo(

        string pNombre, int pCant)
        :base(pNombre,  pCant)
    {

    }

    public MedicamentoParo() { }

    //Polimorfismo
    public override void TipoEquipo()
    {
        Tipo = "Medicamento";
    }

    public override void CategoriaEquipo()
    {
        Categoria = "Paro";
    }

    public override void agregarEquipo(string nombreEquipo, int cantidadEquipo )
    {
        foreach (Historial item in DataBase.HistorialList)
        {
            if (item.Id == DataBase.HistorialList.Count)
            {
                foreach (MedicamentoParo med in DataBase.InventarioMedicamentoParo)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;

                        med.Cant = cantidadEquipo;
                        item.MedicamentoParoList.Add(med);

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
                item.MedicamentoParoList.Clear();

            }
        }
    }

}