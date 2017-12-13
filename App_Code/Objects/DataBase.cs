using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataBase
/// </summary>
public class DataBase
{
    public static List<Historial> HistorialList = new List<Historial>();
    public static List<HerramientaEstabilizador> InventarioHerramientaEstabilizador = new List<HerramientaEstabilizador>();
    public static List<HerramientaIntubacion> InventarioHerramientaIntubacion = new List<HerramientaIntubacion>();
    public static List<HerramientaOxigeno> InventarioHerramientaOxigeno = new List<HerramientaOxigeno>();
    public static List<MedicamentoSuero> InventarioMedicamentoSuero = new List<MedicamentoSuero>();
    public static List<MedicamentoAmpolla> InventarioMedicamentoAmpolla = new List<MedicamentoAmpolla>();
    public static List<MedicamentoParo> InventarioMedicamentoParo = new List<MedicamentoParo>();

    public DataBase()
    {
    }

    public void crearInventario()
    {
        MedicamentoAmpolla medicamento = new MedicamentoAmpolla("buscapina", 5);
        MedicamentoAmpolla medicamento2 = new MedicamentoAmpolla("voltaren", 10);
        medicamento.TipoEquipo();
        medicamento2.TipoEquipo();
        medicamento.CategoriaEquipo();
        medicamento2.CategoriaEquipo();
        InventarioMedicamentoAmpolla.Add(medicamento);
        InventarioMedicamentoAmpolla.Add(medicamento2);

        MedicamentoSuero medicamento3 = new MedicamentoSuero("Suero dextrosa50% 50ml", 1);
        MedicamentoSuero medicamento4 = new MedicamentoSuero("Suero Fisiologico 100ml", 1);
        medicamento3.TipoEquipo();
        medicamento4.TipoEquipo();
        medicamento3.CategoriaEquipo();
        medicamento4.CategoriaEquipo();
        InventarioMedicamentoSuero.Add(medicamento3);
        InventarioMedicamentoSuero.Add(medicamento4);

        MedicamentoParo medicamento5 = new MedicamentoParo("Epinefrina", 20);
        MedicamentoParo medicamento6 = new MedicamentoParo("Artropina", 10);
        medicamento5.TipoEquipo();
        medicamento6.TipoEquipo();
        medicamento5.CategoriaEquipo();
        medicamento6.CategoriaEquipo();
        InventarioMedicamentoParo.Add(medicamento5);
        InventarioMedicamentoParo.Add(medicamento6);



        HerramientaEstabilizador herramienta = new HerramientaEstabilizador("Cojin lateral", 2);
        HerramientaEstabilizador herramienta2 = new HerramientaEstabilizador("Cuello de carton", 9);
        herramienta.TipoEquipo();
        herramienta2.TipoEquipo();
        herramienta.CategoriaEquipo();
        herramienta2.CategoriaEquipo();

        InventarioHerramientaEstabilizador.Add(herramienta);
        InventarioHerramientaEstabilizador.Add(herramienta2);

        HerramientaIntubacion herramienta3 = new HerramientaIntubacion("Hola articulada", 6);
        HerramientaIntubacion herramienta4 = new HerramientaIntubacion("Mangos con bateria", 2);
        herramienta3.TipoEquipo();
        herramienta4.TipoEquipo();
        herramienta3.CategoriaEquipo();
        herramienta4.CategoriaEquipo();

        InventarioHerramientaIntubacion.Add(herramienta3);
        InventarioHerramientaIntubacion.Add(herramienta4);

        HerramientaOxigeno herramienta5 = new HerramientaOxigeno("Mangeras de alta presion", 2);
        HerramientaOxigeno herramienta6 = new HerramientaOxigeno("Mascarilla", 1);
        herramienta5.TipoEquipo();
        herramienta6.TipoEquipo();
        herramienta5.CategoriaEquipo();
        herramienta6.CategoriaEquipo();

        InventarioHerramientaOxigeno.Add(herramienta5);
        InventarioHerramientaOxigeno.Add(herramienta6);
    }

    public void createEmpyHistory()//Crea una nueva lista vacia con solamente el ID (agregado automaticamente) y el valor de "Submitted" en false
    {
        if (HistorialList.Count > 0)
        {
            if (HistorialSubmitted() == true)
            {
                Historial newHistorial = new Historial((HistorialList.Count + 1), false);
                HistorialList.Add(newHistorial);
            }

        }
        else
        {
            Historial newHistorial = new Historial(1, false);
            HistorialList.Add(newHistorial);
        }
    }


    public Boolean HistorialSubmitted()
    {
        foreach (Historial item in HistorialList)
        {
            if (item.Id == HistorialList.Count())
            {
                if (item.Submitted == true)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public string encuentraHistorial(string cedula)
    {
        string historialString = "No existe";

        try
        {
            List<Historial> historialEncontrado = new List<Historial>();

            foreach (Historial item in HistorialList)
            {
                if (item.Cedula == Int32.Parse(cedula))
                {
                    historialEncontrado.Add(item);
                    historialString = String.Join(", ", historialEncontrado);
                }
            }
            return historialString;

        }catch(Exception h)
        {
            return historialString;
        }
        
    }

    public string encuentraEquipo(string tipo)
    {
        string EquipoEncontrado="";
        
        if (tipo=="Medicamento")
        {
            EquipoEncontrado = String.Join(", ",InventarioMedicamentoAmpolla)+"\n"+ String.Join(", ", InventarioMedicamentoParo) + "\n" + String.Join(", ", InventarioMedicamentoSuero);

        }
        else if(tipo=="Herramienta") {
            EquipoEncontrado = String.Join(", ", InventarioHerramientaEstabilizador) + "\n" + String.Join(", ", InventarioHerramientaIntubacion) + "\n" + String.Join(", ", InventarioHerramientaOxigeno);

        }
        else if (tipo == "all")
        {
            EquipoEncontrado = String.Join(", ", InventarioHerramientaEstabilizador) + "\n" + String.Join(", ", InventarioHerramientaIntubacion) + "\n" + String.Join(", ", InventarioHerramientaOxigeno)
                + String.Join(", ", InventarioMedicamentoAmpolla) + "\n" + String.Join(", ", InventarioMedicamentoParo) + "\n" + String.Join(", ", InventarioMedicamentoSuero);
        }
        else
        {
            EquipoEncontrado = "No existe";
        }
        return EquipoEncontrado;
    }

}