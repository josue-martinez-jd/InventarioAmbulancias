using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    //------------------------------------------------Page Load------------------------------------------------
    protected void Page_Load(object sender, EventArgs e)
    {
        HistorialCrear historial = new HistorialCrear();
        historial.createEmpyHistory();

        if (!IsPostBack) {
            drpNombreHerramienta.Items.Add("");
            drpNombreHerramienta.Items.Add("Cojin lateral");
            drpNombreHerramienta.Items.Add("Mangos con bateria");
            drpNombreHerramienta.Items.Add("Cuello de carton");
            drpNombreHerramienta.Items.Add("Hola articulada");
            drpNombreHerramienta.Items.Add("Mangueras de alta presion");
            drpNombreHerramienta.Items.Add("Mascarilla");
            drpNombreMedicamento.Items.Add("");
            drpNombreMedicamento.Items.Add("buscapina");
            drpNombreMedicamento.Items.Add("voltaren");
            drpNombreMedicamento.Items.Add("Suero dextrosa50% 50ml");
            drpNombreMedicamento.Items.Add("Suero Fisiologico 100ml");
            drpNombreMedicamento.Items.Add("Epinefrina");
            drpNombreMedicamento.Items.Add("Artropina");
            InicializarInventario inicializar = new InicializarInventario();
            if (InicializarInventario.inicializado == false)
            {
                inicializar.crearInventario();
                InicializarInventario.inicializado = true;
            }
            
        }
    }

    //--------------------------------------------Guarda la Boleta---------------------------------------------
    protected void btnGuardarBoleta_Click(object sender, EventArgs e)
    { setForm(); }

    //------------------------------------Agrega Medicamentos y Equipo al Historial------------------------------------
    protected void btnAgregarMedicamento_Click(object sender, EventArgs e)
    {
        try
        {
            MedicamentoAmpolla medicamentoAmpolla = new MedicamentoAmpolla();
            MedicamentoParo medicamentoParo = new MedicamentoParo();
            MedicamentoSuero medicamentoSuero = new MedicamentoSuero();

            if(validaCantidadEquipo()==true)
            {
                medicamentoAmpolla.agregarEquipo(drpNombreMedicamento.SelectedItem.Text, Int32.Parse(txtCantidadMedicamento.Text));
                medicamentoParo.agregarEquipo(drpNombreMedicamento.SelectedItem.Text, Int32.Parse(txtCantidadMedicamento.Text));
                medicamentoSuero.agregarEquipo(drpNombreMedicamento.SelectedItem.Text, Int32.Parse(txtCantidadMedicamento.Text));
                lblTestHistorial.Text = "Medicamento agregado con exito";
            }
            else
            {
                lblTestHistorial.Text = "No quedan suficientes unidades";
            }
    }
        catch (Exception h) { lblTestHistorial.Text = "Error al agregar Medicamento"; }
    }

    protected void btnAgregarHerramienta_Click(object sender, EventArgs e)
    {
        try
        {
            HerramientaEstabilizador herramientaEstabilizador = new HerramientaEstabilizador();
            HerramientaIntubacion herramientaIntubacion = new HerramientaIntubacion();
            HerramientaOxigeno herramientaOxigeno = new HerramientaOxigeno();

            if (validaCantidadEquipo() == true)
            {
                herramientaEstabilizador.agregarEquipo(drpNombreHerramienta.SelectedItem.Text, Int32.Parse(txtCantidadHerramienta.Text));
                herramientaIntubacion.agregarEquipo(drpNombreHerramienta.SelectedItem.Text, Int32.Parse(txtCantidadHerramienta.Text));
                herramientaOxigeno.agregarEquipo(drpNombreHerramienta.SelectedItem.Text, Int32.Parse(txtCantidadHerramienta.Text));
                lblTestHistorial.Text = "Herramienta agregada con exito";
            }
            else
            {
                lblTestHistorial.Text = "No quedan suficientes unidades";
            }
        }
        catch (Exception h) { lblTestHistorial.Text = "Error al agregar Herramienta"; }
    }
    
    //----------------------Retorna el valor de los Checkboxes y Textboxes para ser guardados en el historial-----------------------
    public string returnTextOrChecked(CheckBox checkBox,TextBox textBox)
    {
        if (checkBox.Checked)
        {
            return "Ninguno";
        }
        else
        {
            return textBox.Text;
        }
    }

    public string returnChecked(CheckBox checkBox)
    {
        if (checkBox.Checked)
        {
            return "Si";
        }
        else
        {
            return "No";
        }
    }

    public string returnApp()
    {
        string Apps="";

        if (chkDMelitus.Checked)
        {
            Apps = Apps + " D.Melitus ,";
        }
        if (chkHTA.Checked)
        {
            Apps = Apps + " HTA ,";
        }
        if (chkIAM.Checked)
        {
            Apps = Apps + " IAM ,";
        }
        if (chkAsma.Checked)
        {
            Apps = Apps + " Asma ,";
        }if (chkICC.Checked)
        {
            Apps = Apps + " ICC ,";
        }
        if (chkTiroidea.Checked)
        {
            Apps = Apps + " Enfermedad tiroidea ,";
        }
        if (txtOtrosAPP.Text != "")
        {
            Apps = Apps + " Otros: "+ txtOtrosAPP.Text;
        }
        if (chkNoAPP.Checked)
        {
            Apps = "No App";
        }
        return Apps;
    }

    //------------------------------------Se agregan los valores escogidos de la Boleta------------------------------------
    public void setForm()
    {
        try {
            foreach (Historial item in InicializarInventario.HistorialList)
            {
                if (item.Id == InicializarInventario.HistorialList.Count)
                {
                    if (txtFecha.Text != "" && txtMedico.Text != ""&& txtParamedico.Text != ""&& txtUnidad.Text != ""&& txtBase.Text != "" && txtNombrePaciente.Text != "" && Int32.Parse(txtEdad.Text) > 0 && Int32.Parse(txtCedula.Text) > 0 && txaHistoriaClinica.Value != "")
                    {
                        item.Fecha = txtFecha.Text;
                        item.Medico = txtMedico.Text;
                        item.Paramedico = txtParamedico.Text;
                        item.Unidad = txtUnidad.Text;
                        item.Base = txtBase.Text;
                        item.NombrePaciente = txtNombrePaciente.Text;
                        item.Edad = Int32.Parse(txtEdad.Text);
                        item.Cedula = Int32.Parse(txtCedula.Text);
                        item.HistoriaClinica = txaHistoriaClinica.Value;
                        item.App = this.returnApp();
                        item.Tratamiento = this.returnTextOrChecked(chkNoTratamiento, txtTratamiento);
                        item.Alergia = this.returnTextOrChecked(chkAlergias, txtAlergias);
                        item.Consciente = this.returnChecked(chkConsciente);
                        item.Orientado = this.returnChecked(chkOrientado);
                        item.DeficitMotor = this.returnChecked(chkNoDeficitMotor);
                        item.DeficitSensitivo = this.returnChecked(chkNoDeficitSensitivo);
                        item.GlasgowNormal = this.returnChecked(chkNormal);
                        item.GlasgowEspontanea = this.returnChecked(chkEspontanea);
                        item.GlasgowReactiva = this.returnChecked(chkReactiva);
                        item.GlasgowNinguno = this.returnChecked(chkNinguno);
                        item.GlasgowOcular = this.returnChecked(chkOcular);
                        item.GlasgowMidriasis = this.returnChecked(chkMidriasis);
                        item.GlasgowDolor = this.returnChecked(chkDolor);
                        item.GlasgowVoz = this.returnChecked(chkVoz);
                        item.GlasgowMiosis = this.returnChecked(chkMiosis);
                        item.FaringeNormal = this.returnChecked(chkFaringeNormal);
                        item.ConductosAuditNormal = this.returnChecked(chkCondAudiNormal);
                        item.MembranaTimpNormal = this.returnChecked(ckMembTimpNormal); //frontend, deberia ser chkMembTimpNormal
                        item.AmigdalasNormal = this.returnChecked(chkAmigdalasNormales);
                        item.Ingurgitacion = this.returnChecked(chkNoIngurgitacion);
                        item.LlenadoCap = this.returnChecked(chkLlenadoCapilar);
                        item.RsCsRs = this.returnChecked(chkRsCsRs);
                        item.PulsosNormales = this.returnChecked(chkPulsosNormales);
                        item.Submitted = true;

                        lblTestHistorial.Text = "Boleta guardada con exito";
                        clearForm();
                    }
                    else
                    {
                        lblTestHistorial.Text = "No se aceptan campos vacios o numeros menores a cero";
                    }
                }
            }
        }
        catch(Exception h) { lblTestHistorial.Text = "Valores invalidos, intente de nuevo"; }
    }

    //--------------------------------------------Checkboxes Mujer/Hombre--------------------------------------------
    protected void chkMujer_CheckedChanged(object sender, EventArgs e)
    {
        chkMujer.Checked = !chkHombre.Checked;
    }

    protected void chkHombre_CheckedChanged(object sender, EventArgs e)
    {
        chkHombre.Checked = !chkMujer.Checked;
    }

    //-------------------------------Se limpian los Textboxes y Checkboxes de la Boleta-------------------------------
    public void clearTextbox(TextBox textBox)
    { textBox.Text = ""; }

    public void clearCheckbox(CheckBox checkBox)
    { checkBox.Checked = false; }

    public void clearForm()
    {
        clearTextbox(txtMedico);
        clearTextbox(txtAlergias);
        clearTextbox(txtBase);
        clearTextbox(txtCantidadHerramienta);
        clearTextbox(txtCantidadMedicamento);
        clearTextbox(txtCedula);
        clearTextbox(txtEdad);
        clearTextbox(txtNombrePaciente);
        clearTextbox(txtOtrosAPP);
        clearTextbox(txtParamedico);
        clearTextbox(txtTratamiento);
        clearTextbox(txtUnidad);
        clearCheckbox(chkAlergias);
        clearCheckbox(chkAmigdalasNormales);
        clearCheckbox(chkAsma);
        clearCheckbox(chkCondAudiNormal);
        clearCheckbox(chkConsciente);
        clearCheckbox(chkDMelitus);
        clearCheckbox(chkDolor);
        clearCheckbox(chkEspontanea);
        clearCheckbox(chkFaringeNormal);
        clearCheckbox(chkHombre);
        clearCheckbox(chkHTA);
        clearCheckbox(chkIAM);
        clearCheckbox(chkICC);
        clearCheckbox(chkLlenadoCapilar);
        clearCheckbox(chkMidriasis);
        clearCheckbox(chkMiosis);
        clearCheckbox(chkMujer);
        clearCheckbox(chkNinguno);
        clearCheckbox(chkNoAPP);
        clearCheckbox(chkNoDeficitMotor);
        clearCheckbox(chkNoDeficitSensitivo);
        clearCheckbox(chkNoIngurgitacion);
        clearCheckbox(chkNormal);
        clearCheckbox(chkNoTratamiento);
        clearCheckbox(chkOcular);
        clearCheckbox(chkOrientado);
        clearCheckbox(chkPulsosNormales);
        clearCheckbox(chkReactiva);
        clearCheckbox(chkRsCsRs);
        clearCheckbox(chkTiroidea);
        clearCheckbox(chkVoz);
        clearCheckbox(ckMembTimpNormal);
    }

    //--------------------------Valida que se utilicen equipos solo si hay en el inventario---------------------------
    public Boolean validaCantidadEquipo()
    {
        switch (drpNombreHerramienta.SelectedItem.Text)
        {
            case "Cojin lateral":
                if (InicializarInventario.InventarioHerramientaEstabilizador[0].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
            case "Mangos con bateria":
                if (InicializarInventario.InventarioHerramientaIntubacion[1].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
            case "Cuello de carton":
                if (InicializarInventario.InventarioHerramientaEstabilizador[1].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
            case "Hola articulada":
                if (InicializarInventario.InventarioHerramientaIntubacion[0].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
            case "Mangueras de alta presion":
                if (InicializarInventario.InventarioHerramientaOxigeno[0].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
            case "Mascarilla":
                if (InicializarInventario.InventarioHerramientaOxigeno[1].Cant >= Int32.Parse(txtCantidadHerramienta.Text))
                {
                    return true;
                }
                break;
        }
        switch (drpNombreMedicamento.SelectedItem.Text)
        {
            case "buscapina":
                if (InicializarInventario.InventarioMedicamentoAmpolla[0].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
            case "voltaren":
                if (InicializarInventario.InventarioMedicamentoAmpolla[1].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
            case "Suero dextrosa50% 50ml":
                if (InicializarInventario.InventarioMedicamentoSuero[0].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
            case "Suero Fisiologico 100ml":
                if (InicializarInventario.InventarioMedicamentoSuero[1].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
            case "Epinefrina":
                if (InicializarInventario.InventarioMedicamentoParo[0].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
            case "Artropina":
                if (InicializarInventario.InventarioMedicamentoParo[1].Cant >= Int32.Parse(txtCantidadMedicamento.Text))
                {
                    return true;
                }
                break;
        }
        return false;
    }
}


