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
    public MedicamentoAmpolla( string pNombre, int pCant):base(pNombre,  pCant) { }

    public MedicamentoAmpolla() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo= "Medicamento"; }

    public override void CategoriaEquipo()
    { Categoria = "Ampolla"; }

    public override void agregarEquipo( string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (MedicamentoAmpolla med in InicializarInventario.InventarioMedicamentoAmpolla)
                {
                    if (med.Nombre == nombreEquipo)
                    {
                        int cantMedicamentoMax = med.Cant;
                        med.Cant = cantidadEquipo;
                        item.MedicamentoAmpollaList.Add(med);

                        if (med.Cant == cantidadEquipo)
                        { med.Cant = cantMedicamentoMax - cantidadEquipo; }
                    }
                }
            }
        }
    }

    public override void descartarEquipo()
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            { item.MedicamentoAmpollaList.Clear(); }
        }
    }
}