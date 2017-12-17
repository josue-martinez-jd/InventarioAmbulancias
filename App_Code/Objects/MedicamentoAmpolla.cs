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
                foreach (MedicamentoAmpolla medicamento in InicializarInventario.InventarioMedicamentoAmpolla)
                {
                    if (medicamento.Nombre == nombreEquipo)
                    {
                        medicamento.Cant = medicamento.Cant - cantidadEquipo;
                        item.MedicamentoAmpollaList.Add(medicamento);
                    }
                }
            }
        }
    }
}