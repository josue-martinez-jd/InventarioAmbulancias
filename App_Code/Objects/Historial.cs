using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Historial
/// </summary>
public class Historial 
{
    public static List<Historial> HistorialList = new List<Historial>();

    private int _id;
    private string _medico;
    private string _paramedico;
    private string _unidad;
    private string _base;

    private string _nombrePaciente;
    private int _edad;
    private string _sexo;
    private int _cedula;
    private string _historiaClinica;
    private string _app;

    private string _tratamiento;
    private string _alergia;

    private string _consciente;
    private string _orientado;
    private string _DeficitMotor;
    private string _DeficitSensitivo;

    private string _llenadoCap;
    private string _Ingurgitacion;
    private string _pulsosNormales;
    private string _RsCsRs;

    private string _faringeNormal;
    private string _conductosAuditNormal;
    private string _membranaTimpNormal;
    private string _amigdalasNormal;

    private string _glasgowNormal;
    private string _glasgowEspontanea;
    private string _glasgowReactiva;
    private string _glasgowNinguno;
    private string _glasgowOcular;
    private string _glasgowMidriasis;
    private string _glasgowDolor;
    private string _glasgowMiosis;
    private string _glasgowVoz;
    private Boolean _submitted;
    
    private List<Medicamento> _MedicamentoList = new List<Medicamento>();
    private List<Equipo> _EquipoList = new List<Equipo>();

    public Historial( int pId, Boolean pSubmitted )
    {
    Submitted = pSubmitted;
    Id = pId;

}

    public Boolean Submitted
    { get { return _submitted; } set { _submitted = value; } }

    public int Id
    { get { return _id; } set {
            if (_submitted == false)
            { _id = value; } } }

    public List<Medicamento> MedicamentoList
    { get { return _MedicamentoList; } set { _MedicamentoList = value; } }

    public List<Equipo> EquipoList
    { get { return _EquipoList; } set { _EquipoList = value; } }

    public string Medico
    { get { return _medico; } set { _medico = value; } }

    public string Paramedico
    { get { return _paramedico; } set { _paramedico = value; } }

    public string Unidad
    { get { return _unidad; } set { _unidad = value; } }

    public string Base
    { get { return _base; } set { _base = value; } }

    public string NombrePaciente
    { get { return _nombrePaciente; } set { _nombrePaciente = value; } }

    public int Edad
    { get { return _edad; } set { _edad = value; } }

    public string Sexo
    { get { return _sexo; } set { _sexo = value; } }

    public int Cedula
    { get { return _cedula; } set { _cedula = value; } }

    public string HistoriaClinica
    { get { return _historiaClinica; } set { _historiaClinica = value; } }

    public string App
    { get { return _app; } set { _app = value; } }

    public string Tratamiento
    { get { return _tratamiento; } set { _tratamiento = value; } }

    public string Alergia
    { get { return _alergia; } set { _alergia = value; } }

    public string Consciente
    { get { return _consciente; } set { _consciente = value; } }

    public string Orientado
    { get { return _orientado; } set { _orientado = value; } }

    public string DeficitMotor
    { get { return _DeficitMotor; } set { _DeficitMotor = value; } }

    public string DeficitSensitivo
    { get { return _DeficitSensitivo; } set { _DeficitSensitivo = value; } }

    public string LlenadoCap
    { get { return _llenadoCap; } set { _llenadoCap = value; } }

    public string Ingurgitacion
    { get { return _Ingurgitacion; } set { _Ingurgitacion = value; } }

    public string PulsosNormales
    { get { return _pulsosNormales; } set { _pulsosNormales = value; } }

    public string RsCsRs
    { get { return _RsCsRs; } set { _RsCsRs = value; } }

    public string FaringeNormal
    { get { return _faringeNormal; } set { _faringeNormal = value; } }

    public string ConductosAuditNormal
    { get { return _conductosAuditNormal; } set { _conductosAuditNormal = value; } }

    public string MembranaTimpNormal
    { get { return _membranaTimpNormal; } set { _membranaTimpNormal = value; } }

    public string AmigdalasNormal
    { get { return _amigdalasNormal; } set { _amigdalasNormal = value; } }

    public string GlasgowNormal
    { get { return _glasgowNormal; } set { _glasgowNormal = value; } }

    public string GlasgowEspontanea
    { get { return _glasgowEspontanea; } set { _glasgowEspontanea = value; } }

    public string GlasgowReactiva
    { get { return _glasgowReactiva; } set { _glasgowReactiva = value; } }

    public string GlasgowNinguno
    { get { return _glasgowNinguno; } set { _glasgowNinguno = value; } }

    public string GlasgowOcular
    { get { return _glasgowOcular; } set { _glasgowOcular = value; } }

    public string GlasgowMidriasis
    { get { return _glasgowMidriasis; } set { _glasgowMidriasis = value; } }

    public string GlasgowDolor
    { get { return _glasgowDolor; } set { _glasgowDolor = value; } }

    public string GlasgowMiosis
    { get { return _glasgowMiosis; } set { _glasgowMiosis = value; } }

    public string GlasgowVoz
    { get { return _glasgowVoz; } set { _glasgowVoz = value; } }

    public override string ToString()
    {
        return "Id: "+_id + ""+_medico + ", Paramedico: " + _paramedico + ", Unidad: " + _unidad + ", Base: " + _base + ", Nombre del Paciente: " + _nombrePaciente + ", Edad: " + _edad + ", Sexp: " + _sexo 
            + ", Cedula: " + _cedula + ", Historia Clinica: " + _historiaClinica + ", App: " + _app + ", Tratamientos: " + _tratamiento + ", Alergias: " + _alergia + ", Consciente: " + _consciente 
            + ", Orientado: " + _orientado + ", Deficit Motor: " + _DeficitMotor + ", Deficit Sensitivo: " + _DeficitSensitivo + ", Llenado Capilar < 2s"+ _llenadoCap + ", Ingurgitacion: "+ _Ingurgitacion 
            + ", Pulsos Normales: "+_pulsosNormales+", RsCsRs: "+_RsCsRs+", Faringe Normal: "+_faringeNormal+", Conductos Auditivos Normales; "+_conductosAuditNormal+", Membrana Timpanica Normal: "+ _membranaTimpNormal 
            + ", Amigdalas Normales: " + _amigdalasNormal + ", Glasgow Normal: " + _glasgowNormal + ", Glasgow Espontanea: " + _glasgowEspontanea + ", Glasgow Reactiva: " + _glasgowReactiva 
            + ", Ningun Glasgow: " + _glasgowNinguno + ", Glasgow Ocular: " + _glasgowOcular + ", Glasgow Midriasis: " +_glasgowMidriasis + ", Glasgow Dolor: " + _glasgowDolor +", Glasgow Miosis: " + _glasgowMiosis 
            + ", Glasgow Voz: " + _glasgowVoz  + ", Medicamentos utilizados: " + _MedicamentoList + ", Equipo utilizado: " + _EquipoList ;
    }

    public static int HistorialListLength()
    {
        if (HistorialList != null)
        {
            return HistorialList.Count;
        }
        else
        {
            return 1;
        }
    }

    public static void createEmpyHistory()
    {
        if (HistorialList != null)
        {
            foreach (Historial item in HistorialList)
            {
                if (item.Id == HistorialListLength())
                {
                    if (item.Submitted == true)
                    {
                        Historial newHistorial = new Historial((HistorialListLength() + 1), false);
                    }
                    else
                    {
                        //ERROR: Debe completar o descartar el formulario actual antes de crear otro.
                    }
                }
            }
        }
        else
        {
            Historial newHistorial = new Historial((HistorialListLength() + 1), false);
        }
    }

    public static void deleteCurentHistory()
    {
        foreach (Historial item in HistorialList)
        {
            if (item.Id == HistorialListLength())
            {
                HistorialList.Remove(item);
                //MSJ: Debe completar o descartar el formulario actual antes de crear otro.

            }
        }

    }

}