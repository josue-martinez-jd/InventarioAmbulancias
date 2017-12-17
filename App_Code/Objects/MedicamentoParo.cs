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
    public MedicamentoParo( string pNombre, int pCant):base(pNombre,  pCant) { }

    public MedicamentoParo() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo = "Medicamento"; }

    public override void CategoriaEquipo()
    { Categoria = "Paro"; }

    public override void agregarEquipo(string nombreEquipo, int cantidadEquipo )
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (MedicamentoParo medicamento in InicializarInventario.InventarioMedicamentoParo)
                {
                    if (medicamento.Nombre == nombreEquipo)
                    {
                        medicamento.Cant = medicamento.Cant - cantidadEquipo;
                        item.MedicamentoParoList.Add(medicamento);
                    }
                }
            }
        }
    }
}