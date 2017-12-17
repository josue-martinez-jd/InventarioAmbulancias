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
    public MedicamentoSuero( string pNombre, int pCant):base(pNombre,  pCant) { }

    public MedicamentoSuero() { }

    //Polimorfismo
    public override void TipoEquipo()
    { Tipo = "Medicamento"; }

    public override void CategoriaEquipo()
    { Categoria = "Suero"; }

    public override void agregarEquipo(string nombreEquipo, int cantidadEquipo)
    {
        foreach (Historial item in InicializarInventario.HistorialList)
        {
            if (item.Id == InicializarInventario.HistorialList.Count)
            {
                foreach (MedicamentoSuero medicamento in InicializarInventario.InventarioMedicamentoSuero)
                {
                    if (medicamento.Nombre == nombreEquipo)
                    {
                        medicamento.Cant = medicamento.Cant - cantidadEquipo;
                        item.MedicamentoSueroList.Add(medicamento);
                    }
                }
            }
        }
    }
}