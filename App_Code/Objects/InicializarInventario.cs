using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataBase
/// </summary>
public class InicializarInventario
{
    public static List<Historial> HistorialList = new List<Historial>();
    public static List<HerramientaEstabilizador> InventarioHerramientaEstabilizador = new List<HerramientaEstabilizador>();
    public static List<HerramientaIntubacion> InventarioHerramientaIntubacion = new List<HerramientaIntubacion>();
    public static List<HerramientaOxigeno> InventarioHerramientaOxigeno = new List<HerramientaOxigeno>();
    public static List<MedicamentoSuero> InventarioMedicamentoSuero = new List<MedicamentoSuero>();
    public static List<MedicamentoAmpolla> InventarioMedicamentoAmpolla = new List<MedicamentoAmpolla>();
    public static List<MedicamentoParo> InventarioMedicamentoParo = new List<MedicamentoParo>();
    public static Boolean inicializado = false;

    public InicializarInventario() { }

    public void crearInventario()
    {
        //-----------------Agrega los medicamentos a las listas de inventario----------------
        MedicamentoAmpolla medicamento = new MedicamentoAmpolla("buscapina", 5);
        MedicamentoAmpolla medicamento2 = new MedicamentoAmpolla("voltaren", 10);
        MedicamentoSuero medicamento3 = new MedicamentoSuero("Suero dextrosa50% 50ml", 1);
        MedicamentoSuero medicamento4 = new MedicamentoSuero("Suero Fisiologico 100ml", 1);
        MedicamentoParo medicamento5 = new MedicamentoParo("Epinefrina", 20);
        MedicamentoParo medicamento6 = new MedicamentoParo("Artropina", 10);
        medicamento.TipoEquipo();
        medicamento2.TipoEquipo();
        medicamento.CategoriaEquipo();
        medicamento2.CategoriaEquipo();
        medicamento3.TipoEquipo();
        medicamento4.TipoEquipo();
        medicamento3.CategoriaEquipo();
        medicamento4.CategoriaEquipo();
        medicamento5.TipoEquipo();
        medicamento6.TipoEquipo();
        medicamento5.CategoriaEquipo();
        medicamento6.CategoriaEquipo();
        InventarioMedicamentoAmpolla.Add(medicamento);
        InventarioMedicamentoAmpolla.Add(medicamento2);
        InventarioMedicamentoSuero.Add(medicamento3);
        InventarioMedicamentoSuero.Add(medicamento4);
        InventarioMedicamentoParo.Add(medicamento5);
        InventarioMedicamentoParo.Add(medicamento6);

        //-----------------Agrega las Herramientas a las listas de inventario----------------
        HerramientaEstabilizador herramienta = new HerramientaEstabilizador("Cojin lateral", 2);
        HerramientaEstabilizador herramienta2 = new HerramientaEstabilizador("Cuello de carton", 9);
        HerramientaIntubacion herramienta3 = new HerramientaIntubacion("Hola articulada", 6);
        HerramientaIntubacion herramienta4 = new HerramientaIntubacion("Mangos con bateria", 2);
        HerramientaOxigeno herramienta5 = new HerramientaOxigeno("Mangeras de alta presion", 2);
        HerramientaOxigeno herramienta6 = new HerramientaOxigeno("Mascarilla", 1);
        herramienta.TipoEquipo();
        herramienta2.TipoEquipo();
        herramienta.CategoriaEquipo();
        herramienta2.CategoriaEquipo();
        herramienta3.TipoEquipo();
        herramienta4.TipoEquipo();
        herramienta3.CategoriaEquipo();
        herramienta4.CategoriaEquipo();
        herramienta5.TipoEquipo();
        herramienta6.TipoEquipo();
        herramienta5.CategoriaEquipo();
        herramienta6.CategoriaEquipo();
        InventarioHerramientaEstabilizador.Add(herramienta);
        InventarioHerramientaEstabilizador.Add(herramienta2);
        InventarioHerramientaIntubacion.Add(herramienta3);
        InventarioHerramientaIntubacion.Add(herramienta4);
        InventarioHerramientaOxigeno.Add(herramienta5);
        InventarioHerramientaOxigeno.Add(herramienta6);
    }

    public void LlenarInventario()
    {
        //-----------------Se limpian las listas del inventario y se vuelven a llenar----------------
        InventarioHerramientaEstabilizador.Clear();
        InventarioHerramientaIntubacion.Clear();
        InventarioHerramientaOxigeno.Clear();
        InventarioMedicamentoSuero.Clear();
        InventarioMedicamentoAmpolla.Clear();
        InventarioMedicamentoParo.Clear();
        crearInventario();
    }
}