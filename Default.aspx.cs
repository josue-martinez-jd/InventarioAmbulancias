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
        txaHistoriaClinica.Value = "this test";
        Historial.createEmpyHistory();
       

        if (!IsPostBack) {
            drpCategoriaEquipo.Items.Add("category1");
            drpNombreEquipo.Items.Add("name1");
            drpTipoEquipo.Items.Add("type1");
            drpCategoriaMedicamento.Items.Add("cat1");
            drpNombreMedicamento.Items.Add("nam1");
            drpTipoMedicamento.Items.Add("ty1");
        }
    }

    //--------------------------------------------Guarda la Boleta---------------------------------------------
    protected void btnGuardarBoleta_Click(object sender, EventArgs e)
    {
        lblTestHistorial.Text = txtBase.Text;
        //foreach (Historial item in Historial.HistorialList)
        //{
        //    if (item.Id == Historial.HistorialListLength())
        //    {
        //        this.setForm(item);
        //        //MSJ: Boleta guardada con exito
        //        this.clearForm();
        //    }
        //}

        //lblTestHistorial.Text = Print.printHistorialList();
    }

    //-------------------------------------------Descartar la Boleta-------------------------------------------
    protected void btnDescartarBoleta_Click(object sender, EventArgs e)
    {
        Historial.deleteCurentHistory();
        this.clearForm();
        Historial.createEmpyHistory();
        //MSJ: Boleta descartada con exito
    }

    //------------------------------------Agrega Medicamentos y Equipo al Historial------------------------------------
    protected void btnAgregarMedicamento_Click(object sender, EventArgs e)
    {
        Medicamento newMedicamento = new Medicamento(
            drpCategoriaMedicamento.SelectedItem.Text,drpTipoMedicamento.SelectedItem.Text,
            drpNombreMedicamento.SelectedItem.Text,Int32.Parse(txtCantidadMedicamento.Text));

        foreach(Historial item in Historial.HistorialList)
        {
            if(item.Id== Historial.HistorialListLength())
            {
                item.MedicamentoList.Add(newMedicamento);
            }
        }
        lblTestHistorial.Text = Print.printHistorialList();
    }

    protected void btnAgregarEquipo_Click(object sender, EventArgs e)
    {
        Equipo newEquipo = new Equipo(
            drpCategoriaEquipo.SelectedItem.Text, drpTipoEquipo.SelectedItem.Text, 
            drpNombreEquipo.SelectedItem.Text, Int32.Parse(txtCantidadEquipo.Text));

        foreach (Historial item in Historial.HistorialList)
        {
            if (item.Id == Historial.HistorialListLength())
            {
                item.EquipoList.Add(newEquipo);
            }
        }

        lblTestHistorial.Text = Print.printHistorialList();
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
    public void setForm(Historial item)
    {
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
    {
        textBox.Text = "";
    }

    public void clearCheckbox(CheckBox checkBox)
    {
        checkBox.Checked = false;
    }

    public void clearForm()
    {
        clearTextbox(txtMedico);
        clearTextbox(txtGlicemia);
        clearTextbox(txtAlergias);
        clearTextbox(txtBase);
        clearTextbox(txtCantidadEquipo);
        clearTextbox(txtCantidadMedicamento);
        clearTextbox(txtCedula);
        clearTextbox(txtEdad);
        clearTextbox(txtFC);
        clearTextbox(txtFR);
        clearTextbox(txtNombrePaciente);
        clearTextbox(txtOtrosAPP);
        clearTextbox(txtPA);
        clearTextbox(txtParamedico);
        clearTextbox(txtSatO2);
        clearTextbox(txtTemp);
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
        clearCheckbox(chkNoReactiva);
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

}