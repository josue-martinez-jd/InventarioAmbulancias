using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Historial
/// </summary>
public class Historial 
{
    private int _id;
    private string _fecha;
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
    private List<MedicamentoAmpolla> _MedicamentoAmpollaList = new List<MedicamentoAmpolla>();
    private List<MedicamentoSuero> _MedicamentoSueroList = new List<MedicamentoSuero>();
    private List<MedicamentoParo> _MedicamentoParoList = new List<MedicamentoParo>();
    private List<HerramientaEstabilizador> _HerramientaEstabilizadorList = new List<HerramientaEstabilizador>();
    private List<HerramientaIntubacion> _HerramientaIntubacionList = new List<HerramientaIntubacion>();
    private List<HerramientaOxigeno> _HerramientaOxigenoList = new List<HerramientaOxigeno>();

    //Constructor
    public Historial( int pId, Boolean pSubmitted )
    { Submitted = pSubmitted; Id = pId; }

    //Sets & Gets
    //Tell don't ask
    //En todos se valida que la boleta no se haya guardado. Si esta guardada entonces no se pueden hacer cambios. Se validan int>0
    public Boolean Submitted { get { return _submitted; } set { _submitted = value; } }

    public int Id { get { return _id; } 
        set { if (_submitted == false && value>=0) { _id = value; } }
    }

    public List<MedicamentoAmpolla> MedicamentoAmpollaList { get { return _MedicamentoAmpollaList; }
        set { if (_submitted == false && value != null) { _MedicamentoAmpollaList = value; } }
    }

    public List<MedicamentoSuero> MedicamentoSueroList { get { return _MedicamentoSueroList; }
        set { if (_submitted == false && value != null) { _MedicamentoSueroList = value; } }
    }

    public List<MedicamentoParo> MedicamentoParoList { get { return _MedicamentoParoList; }
        set { if (_submitted == false && value != null) { _MedicamentoParoList = value; } }
    }

    public List<HerramientaEstabilizador> HerramientaEstabilizadorList { get { return _HerramientaEstabilizadorList; }
        set { if (_submitted == false && value != null) { _HerramientaEstabilizadorList = value; } }
    }

    public List<HerramientaIntubacion> HerramientaIntubacionList { get { return _HerramientaIntubacionList; }
        set { if (_submitted == false && value != null) { _HerramientaIntubacionList = value; } }
    }

    public List<HerramientaOxigeno> HerramientaOxigenoList { get { return _HerramientaOxigenoList; }
        set { if (_submitted == false && value != null) { _HerramientaOxigenoList = value; } }
    }

    public string Medico { get { return _medico; }
        set { if(_submitted == false && value != "") { _medico = value; } }
    }

    public string Fecha { get { return _fecha; }
        set { if (_submitted == false && value != "") { _fecha = value; } }
    }

    public string Paramedico { get { return _paramedico; }
        set { if (_submitted == false && value != "") { _paramedico = value; } }
    }

    public string Unidad { get { return _unidad; }
        set { if (_submitted == false && value != "") { _unidad = value; } }
    }

    public string Base { get { return _base; }
        set { if (_submitted == false && value != "") { _base = value; } }
    }

    public string NombrePaciente { get { return _nombrePaciente; }
        set { if (_submitted == false && value != "") { _nombrePaciente = value; } }
    }

    public int Edad { get { return _edad; }
        set { if (_submitted == false && value >= 0) { _edad = value; } }
    }

    public string Sexo { get { return _sexo; }
        set { if (_submitted == false && value != "") { _sexo = value; } }
    }

    public int Cedula { get { return _cedula; }
        set { if (_submitted == false && value >= 0) { _cedula = value; } }
    }

    public string HistoriaClinica { get { return _historiaClinica; }
        set { if (_submitted == false && value !="") { _historiaClinica = value; } }
    }

    public string App { get { return _app; }
        set { if (_submitted == false) { _app = value; } }
    }

    public string Tratamiento { get { return _tratamiento; }
        set { if (_submitted == false) { _tratamiento = value; } }
    }

    public string Alergia { get { return _alergia; }
        set { if (_submitted == false) { _alergia = value; } }
    }

    public string Consciente { get { return _consciente; }
        set { if (_submitted == false) { _consciente = value; } }
    }

    public string Orientado { get { return _orientado; }
        set { if (_submitted == false) { _orientado = value; } }
    }

    public string DeficitMotor { get { return _DeficitMotor; }
        set { if (_submitted == false) { _DeficitMotor = value; } }
    }

    public string DeficitSensitivo { get { return _DeficitSensitivo; }
        set { if (_submitted == false) { _DeficitSensitivo = value; } }
    }

    public string LlenadoCap { get { return _llenadoCap; }
        set { if (_submitted == false) { _llenadoCap = value; } }
    }

    public string Ingurgitacion { get { return _Ingurgitacion; }
        set { if (_submitted == false) { _Ingurgitacion = value; } }
    }

    public string PulsosNormales { get { return _pulsosNormales; }
        set { if (_submitted == false) { _pulsosNormales = value; } }
    }

    public string RsCsRs { get { return _RsCsRs; }
        set { if (_submitted == false) { _RsCsRs = value; } }
    }

    public string FaringeNormal { get { return _faringeNormal; }
        set { if (_submitted == false) { _faringeNormal = value; } }
    }

    public string ConductosAuditNormal { get { return _conductosAuditNormal; }
        set { if (_submitted == false) { _conductosAuditNormal = value; } }
    }

    public string MembranaTimpNormal { get { return _membranaTimpNormal; }
        set { if (_submitted == false) { _membranaTimpNormal = value; } }
    }

    public string AmigdalasNormal { get { return _amigdalasNormal; }
        set { if (_submitted == false) { _amigdalasNormal = value; } }
    }

    public string GlasgowNormal { get { return _glasgowNormal; }
        set { if (_submitted == false) { _glasgowNormal = value; } }
    }

    public string GlasgowEspontanea { get { return _glasgowEspontanea; }
        set { if (_submitted == false) { _glasgowEspontanea = value; } }
    }

    public string GlasgowReactiva { get { return _glasgowReactiva; }
        set { if (_submitted == false) { _glasgowReactiva = value; } }
    }

    public string GlasgowNinguno { get { return _glasgowNinguno; }
        set { if (_submitted == false) { _glasgowNinguno = value; } }
    }

    public string GlasgowOcular { get { return _glasgowOcular; }
        set { if (_submitted == false) { _glasgowOcular = value; } }
    }

    public string GlasgowMidriasis { get { return _glasgowMidriasis; }
        set { if (_submitted == false) { _glasgowMidriasis = value; } }
    }

    public string GlasgowDolor { get { return _glasgowDolor; }
        set { if (_submitted == false) { _glasgowDolor = value; } }
    }

    public string GlasgowMiosis { get { return _glasgowMiosis; }
        set { if (_submitted == false) { _glasgowMiosis = value; } }
    }

    public string GlasgowVoz { get { return _glasgowVoz; }
        set { if (_submitted == false) { _glasgowVoz = value; } }
    }

    public override string ToString()
    {
        return "\n Id: "+_id + ", Fecha: "+ _fecha + ", Medico: "+_medico + ", Paramedico: " + _paramedico + ", Unidad: " + _unidad + ", Base: " + _base + "\n, Nombre del Paciente: " + _nombrePaciente + ", Edad: " + _edad + ", Sexo: " + _sexo 
            + ", Cedula: " + _cedula + ", Historia Clinica: " + _historiaClinica + ", App: " + _app + ", Tratamientos: " + _tratamiento + ", Alergias: " + _alergia + "\n, Consciente: " + _consciente 
            + ", Orientado: " + _orientado + ", Deficit Motor: " + _DeficitMotor + ", Deficit Sensitivo: " + _DeficitSensitivo + ", Llenado Capilar < 2s"+ _llenadoCap + ", Ingurgitacion: "+ _Ingurgitacion 
            + ", Pulsos Normales: "+_pulsosNormales+", RsCsRs: "+_RsCsRs+", Faringe Normal: "+_faringeNormal+", Conductos Auditivos Normales; "+_conductosAuditNormal+", Membrana Timpanica Normal: "+ _membranaTimpNormal 
            + ", Amigdalas Normales: " + _amigdalasNormal + ", Glasgow Normal: " + _glasgowNormal + ", Glasgow Espontanea: " + _glasgowEspontanea + ", Glasgow Reactiva: " + _glasgowReactiva 
            + ", Ningun Glasgow: " + _glasgowNinguno + ", Glasgow Ocular: " + _glasgowOcular + ", Glasgow Midriasis: " +_glasgowMidriasis + ", Glasgow Dolor: " + _glasgowDolor +", Glasgow Miosis: " + _glasgowMiosis 
            + ", Glasgow Voz: " + _glasgowVoz  + ", Equipo utilizado: " + string.Join(", ", _MedicamentoAmpollaList)+ string.Join(", ", _MedicamentoSueroList) + string.Join(", ", _MedicamentoParoList) 
            + string.Join(", ", HerramientaEstabilizadorList) + string.Join(", ", HerramientaIntubacionList) + string.Join(", ", HerramientaOxigenoList) + ", Submitted: " +_submitted+"\n";
    }
}