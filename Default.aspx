
    <%@ Page Title="Home Page" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
      
        <table class="nav-justified">
            <tr>
                <td style="width: 275px">
                    <img src="../media/emergenciasLogo.png" style="width: 257px; height: 238px" /></td>
                <td>&nbsp;
                     
        <h2>BOLETA DE ATENCION DE PACIENTE</h2>
                </td>
            </tr>
        </table>
    </div>
    <asp:Panel runat="server" ID="infoMedicos">
         <div class="row text-style">
        <br />
        <div class="col-xs-4 " > 
            Fecha: <asp:TextBox class="textBoxes" ID="txtFecha" type="date" runat="server"  ></asp:TextBox>  
        </div>

        <div class="col-xs-4 " > 
            Medico/TEM: <asp:TextBox class="textBoxes" ID="txtMedico" runat="server"  ></asp:TextBox>  
        </div>
       
        <div class="col-xs-4" > 
            Paramedico: <asp:TextBox class="textBoxes" ID="txtParamedico" runat="server"  ></asp:TextBox>  
        </div>

        <div class="col-xs-4" > 
            Unidad: <asp:TextBox class="textBoxes" ID="txtUnidad" runat="server"  ></asp:TextBox>  
        </div>

        <div class="col-xs-4" > 
            Base: <asp:TextBox class="textBoxes" ID="txtBase" runat="server"  ></asp:TextBox>  
        </div>

         </div>
    </asp:Panel>
   
        <h3 >DATOS DEL PACIENTE</h3>

    <asp:Panel ID="InformacionPaciente" runat="server">
    <asp:Panel ID="PacienteNombreTratamiento" runat="server">
        <div class="row text-style" >
            <div class="col-xs-4" >Nombre Completo:
                <asp:TextBox class="textBoxes" ID="txtNombrePaciente" runat="server"  ></asp:TextBox>
            </div>
            <div class="col-xs-4" >Tratamiento:
                <asp:TextBox class="textBoxes" ID="txtTratamiento" runat="server" ></asp:TextBox>
            </div>
             <div class="col-xs-4">
                 <asp:Label runat="server" style="color:red;width:200px" AssociatedControlID="chkNoTratamiento"> <asp:CheckBox ID="chkNoTratamiento" runat="server" /> No Tratamiento</asp:Label>
            </div>
        </div>
    </asp:Panel>
        <br />
    <asp:Panel ID="EdadSexoPaciente" runat="server">
        <div class="row text-style" >
            <div class="col-xs-4"  >Edad:
                <asp:TextBox class="textBoxes" ID="txtEdad" type="number"  runat="server"  ></asp:TextBox>
            </div>
            <div class="col-xs-4 wide"" >Sexo: 
                <asp:Label runat="server" AssociatedControlID="chkMujer" OnCheckedChanged="chkMujer_CheckedChanged">
                    <asp:CheckBox ID="chkMujer" runat="server"/>&nbsp;Mujer</asp:Label> 
                <asp:Label runat="server" AssociatedControlID="chkHombre" OnCheckedChanged="chkHombre_CheckedChanged">
                    <asp:CheckBox ID="chkHombre" runat="server"/>&nbsp;Hombre</asp:Label> 
            </div>
            <div class="col-xs-4 wide">Cedula:
                 <asp:TextBox class="textBoxes" ID="txtCedula" type="number" runat="server"></asp:TextBox>
            </div>
            <div class="col-xs-4 wide" >Alergias:
                 <asp:TextBox class="textBoxes" ID="txtAlergias"  runat="server" ></asp:TextBox>
            </div>
            <div class="col-xs-4 wide">
                 <asp:Label runat="server" AssociatedControlID="chkAlergias" style="color:red">
                    <asp:CheckBox ID="chkAlergias" runat="server"/>&nbsp;No Alergias</asp:Label> 
            </div>
        </div>
        <br />
        <div class="row text-style" >
            <div class="col-xs-5" style="width:55%;">APP:
                <asp:Label runat="server" AssociatedControlID="chkDMelitus" >
                    <asp:CheckBox ID="chkDMelitus" runat="server"/>D.Melitus</asp:Label> 
                    &nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" AssociatedControlID="chkHTA" >
                    <asp:CheckBox ID="chkHTA" runat="server"/>HTA</asp:Label> 
                    &nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" AssociatedControlID="chkIAM" >
                    <asp:CheckBox ID="chkIAM" runat="server"/>IAM</asp:Label> 
                    &nbsp;&nbsp;&nbsp
                <asp:Label runat="server" AssociatedControlID="chkAsma" >
                    <asp:CheckBox ID="chkAsma" runat="server"/>Asma</asp:Label> 
                    &nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" AssociatedControlID="chkICC" >
                    <asp:CheckBox ID="chkICC" runat="server"/>ICC</asp:Label> 
                    &nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" AssociatedControlID="chkTiroidea" >
                    <asp:CheckBox ID="chkTiroidea" runat="server"/>Enf.Tiroidea</asp:Label> 
                    &nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" style="color:red" AssociatedControlID="chkNoAPP" >
                    <asp:CheckBox ID="chkNoAPP" runat="server"/>No APP</asp:Label> 
            </div>
            <div class="col-xs-5" >Otros: 
            <asp:TextBox class="textBoxes" ID="txtOtrosAPP" runat="server"></asp:TextBox>
        </div>
        </div>
    </asp:Panel>
    </asp:Panel>

    <br />
    <div class="row">
    <div class="col-xs-6">
        <h3 class="SignosVitales_ExamenFisico" >Historia Clinica</h3>
           <asp:Panel ID="HistoriaClinica" class="borders" runat="server">
              <div class="row" >
                  <div class="col-md-6">
                      <textarea runat="server" ID="txaHistoriaClinica"> </textarea>
                  </div>
              </div>
           </asp:Panel>
    </div>

    <div class="col-xs-6" >
        <h3 class="SignosVitales_ExamenFisico" >Examen Fisico</h3>
        <asp:Panel ID="ExamenFisico" class="borders" runat="server">
            <h4>Sistema Neurologico</h4>
        <div class="row">
                <div class="col-xs-2">
            <asp:Label AssociatedControlID="chkConsciente" runat="server">
                <asp:CheckBox ID="chkConsciente" runat="server"/>Consciente
            </asp:Label>
        </div>
            <div class="col-xs-2">
            <asp:Label AssociatedControlID="chkNoDeficitMotor" runat="server">
                <asp:CheckBox ID="chkNoDeficitMotor" runat="server"/>Deficit motor
            </asp:Label>
        </div>
            <div class="col-xs-2">
            <asp:Label AssociatedControlID="chkNoDeficitSensitivo" runat="server">
                <asp:CheckBox ID="chkNoDeficitSensitivo" runat="server"/>Deficit sensitivo
            </asp:Label>
        </div>
            <div class="col-xs-2">
            <asp:Label AssociatedControlID="chkOrientado" runat="server">
                <asp:CheckBox ID="chkOrientado" runat="server"/>Orientado
            </asp:Label>
        </div>
        </div>
        <hr />
            <h4>Escala Glasgow</h4>
        <div class="row">
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkNormal" runat="server">
                    <asp:CheckBox ID="chkNormal" runat="server"/>Normal
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkOcular" runat="server">
                    <asp:CheckBox ID="chkOcular" runat="server"/>Ocular
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkMiosis" runat="server">
                    <asp:CheckBox ID="chkMiosis" runat="server"/>Miosis
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkEspontanea" runat="server">
                    <asp:CheckBox ID="chkEspontanea" runat="server"/>Espontanea
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkMidriasis" runat="server">
                    <asp:CheckBox ID="chkMidriasis" runat="server"/>Midriasis
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkVoz" runat="server">
                    <asp:CheckBox ID="chkVoz" runat="server"/>Voz
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkReactiva" runat="server">
                    <asp:CheckBox ID="chkReactiva" runat="server"/>Reactiva
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkDolor" runat="server">
                    <asp:CheckBox ID="chkDolor" runat="server"/>Dolor
                </asp:Label>
            </div>
            <div class="col-xs-2 lighter">
                <asp:Label AssociatedControlID="chkNinguno" runat="server">
                    <asp:CheckBox ID="chkNinguno" runat="server"/>Ninguno
                </asp:Label>
            </div>
        </div>
        <hr />
            <h4>Oral</h4>
        <div class="row">
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkFaringeNormal" runat="server">
                    <asp:CheckBox ID="chkFaringeNormal" runat="server"/>Faringe Normal
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="ckMembTimpNormal" runat="server">
                    <asp:CheckBox ID="ckMembTimpNormal" runat="server"/>Membram Timp Normal
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkAmigdalasNormales" runat="server">
                    <asp:CheckBox ID="chkAmigdalasNormales" runat="server"/>Amigdalas Normales
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkCondAudiNormal" runat="server">
                    <asp:CheckBox ID="chkCondAudiNormal" runat="server"/>Conductos Audit Normales
                </asp:Label>
            </div>
        </div>
        <hr />
            <h4>Sistema Cardiovascular</h4>
            <div class="row">
                 <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkRsCsRs" runat="server">
                    <asp:CheckBox ID="chkRsCsRs" runat="server"/>RsCsRs
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkNoIngurgitacion" runat="server">
                    <asp:CheckBox ID="chkNoIngurgitacion" runat="server"/>Ingurgitacion
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkLlenadoCapilar" runat="server">
                    <asp:CheckBox ID="chkLlenadoCapilar" runat="server"/>Llenado Cap <2seg
                </asp:Label>
            </div>
            <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkPulsosNormales" runat="server">
                    <asp:CheckBox ID="chkPulsosNormales" runat="server"/>Pulsos Normales
                </asp:Label>
            </div>
            </div>
            
        </asp:Panel>
       
    </div>
    </div>
    
    <br />

        <h3>EQUIPOS UTILIZADOS</h3>
    <asp:Panel ID="Medicamento_Equipo" runat="server">
    <div class ="row text-style">
        <div class="col-xs-6">
            <h3 class="SignosVitales_ExamenFisico">Medicamentos</h3>
            <asp:Panel ID="MedicamentosUtilizados" class="borders" runat="server">
                <div class="row">
                    <div class="col-xs-2" style="width:40%;" >
                         Nombre:<asp:DropDownList ID="drpNombreMedicamento" class="dropdowns" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-xs-2">
                         Cantidad:<asp:TextBox ID="txtCantidadMedicamento" class="textBoxes" type="number" runat="server"></asp:TextBox>
                    </div>
                     <div class="col-xs-2">
                         <asp:Button ID="btnAgregarMedicamento" class="buttons" Text="Agregar"  runat="server" OnClick="btnAgregarMedicamento_Click"/>
                    </div>
                </div>
            </asp:Panel>
        </div>
        <div class="col-xs-6">
            <h3 class="SignosVitales_ExamenFisico">Herramientas</h3>
            <asp:Panel ID="HerramientasUtilizada" class="borders" runat="server">
                <div class="row">
                    <div class="col-xs-2" style="width:40%;" >
                         Nombre:<asp:DropDownList ID="drpNombreHerramienta" class="dropdowns" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-xs-2">
                         Cantidad:<asp:TextBox ID="txtCantidadHerramienta" class="textBoxes" type="number" runat="server"></asp:TextBox>
                    </div>
                     <div class="col-xs-2">
                         <asp:Button ID="btnAgregarHerramienta" class="buttons" Text="Agregar"   runat="server" OnClick="btnAgregarHerramienta_Click"/>
                    </div>
                </div> 
            </asp:Panel>
        </div>
    </div>
    </asp:Panel>
    
    <div class="row">
        <div class="col-xs-6">
            <asp:Button ID="btnGuardarBoleta" Text="Guardar Boleta"  runat="server" OnClick="btnGuardarBoleta_Click"/>
        </div>
        <div class="col-xs-6">
            <asp:Button href="~/" ID="btnDescartarBoleta" Text="Descartar Boleta" style="visibility:hidden;" runat="server"/>
        </div>
    </div>

        <div class="row">
            <div class="col-lg-6">
                <asp:Label ID="lblTestHistorial" style="color:red" runat="server"></asp:Label>
            </div>
        </div>
  
</asp:Content>


