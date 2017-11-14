<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
         <div class="row">
        <br />
        <div class="col-md-2" >  
         <p> Medico/TEM:  </p>
        </div>
        <div class="col-md-2" >
         <asp:TextBox class="textBoxes" ID="txtMedico" runat="server"  ></asp:TextBox>  
        </div>

        <div class="col-md-2">
         <p> &nbsp;Paramedico: </p>
        </div>
         <div class="col-md-2">
             <asp:TextBox class="textBoxes" ID="txtParamedico" runat="server" ></asp:TextBox>
         </div>

        <div class="col-md-2">
         <p> &nbsp;Unidad: </p>
        </div>
         <div class="col-md-2">
             <asp:TextBox class="textBoxes" ID="txtUnidad" runat="server"  ></asp:TextBox>
         </div>

        <div class="col-md-2">
         <p> &nbsp;Base: </p>
        </div>
         <div class="col-md-2">
             <asp:TextBox class="textBoxes" ID="txtBase" runat="server" ></asp:TextBox>
         </div>

         </div>
    </asp:Panel>
   
    <div class="row" >
        <h3 style="color:blue;text-align:center">DATOS DEL PACIENTE</h3>
    </div>
    <asp:Panel ID="InformacionPaciente" runat="server">
        <asp:Panel ID="PacienteNombreTratamiento" runat="server">
        <div class="row" >
        <div class="col-md-2" >
         <p > &nbsp;Nombre Completo: </p>
        </div>
         <div class="col-md-2">
             <asp:TextBox class="textBoxes" ID="txtNombrePaciente" runat="server"  ></asp:TextBox>
         </div>

        <div class="col-md-2" style="margin-left: 2cm;" >
         <p> &nbsp;Tratamiento: </p>
        </div>
         <div class="col-md-2">
             <asp:TextBox class="textBoxes" ID="txtTratamiento" runat="server" ></asp:TextBox>
         </div>

         <div class="col-md-2" style="margin-left: 2cm;">
             <asp:Label runat="server" style="color:red;width:200px" AssociatedControlID="chkNoTratamiento"> <asp:CheckBox ID="chkNoTratamiento" runat="server" /> No Tratamiento</asp:Label>
        </div>
    </div>
    </asp:Panel>
    

    <asp:Panel ID="EdadSexoPaciente" runat="server">
         <div class="row" >
        <div class="col-md-2"  >
            <p > &nbsp;Edad: </p>
        </div>

        <div class="col-md-2"  >
             <asp:TextBox class="textBoxes" ID="txtEdad"  style="width: 50px;" runat="server"  ></asp:TextBox>
        </div>

        <div class="col-md-2" style="margin-left: -0.3cm;" >
            <p > &nbsp;Sexo: </p>
        </div>

        <div class="col-md-2" style="width: 160px;">
            <asp:Label runat="server" AssociatedControlID="chkMujer" OnCheckedChanged="chkMujer_CheckedChanged">
                <asp:CheckBox ID="chkMujer" runat="server"/>&nbsp;Mujer</asp:Label> 
            <asp:Label runat="server" AssociatedControlID="chkHombre" OnCheckedChanged="chkHombre_CheckedChanged">
                <asp:CheckBox ID="chkHombre" runat="server"/>&nbsp;Hombre</asp:Label> 
        </div>

        <div class="col-md-2"  style="width:87px;margin-left: -1cm;">
            <p > &nbsp;Cedula: </p>
        </div>

        <div class="col-md-2" >
             <asp:TextBox class="textBoxes" ID="txtCedula" runat="server"  style="width: 150px; margin-left: -0.6cm;"></asp:TextBox>
        </div>

        <div class="col-md-2" style="margin-left: 2.5cm;" >
         <p> &nbsp;Alergias: </p>
        </div>
         <div class="col-md-2" style=" margin-left: 1.5cm;">
             <asp:TextBox class="textBoxes" ID="txtAlergias" style="width: 300px;" runat="server" ></asp:TextBox>
         </div>

         <div class="col-md-2" style="    margin-left: 6.5cm; width: 200px;">
             <asp:Label runat="server" AssociatedControlID="chkAlergias" style="color:red">
             <asp:CheckBox ID="chkAlergias" runat="server"/>&nbsp;No Alergias</asp:Label> 
        </div>

    </div>

        <div class="row" >
        <div class="col-md-2">
            <p > &nbsp;APP: </p>
        </div>

        <asp:Panel ID="APPCheckboxes" runat="server">
            <div class="col-md-2" style="width: 550px;" >
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
        </asp:Panel>
       
        <div class="col-md-2" style="margin-left: -1.1cm;">
            <p > &nbsp;Otros: </p>
        </div>

        <div class="col-md-2" style="width:500px;" >
            <asp:TextBox class="textBoxes" ID="txtOtrosAPP" runat="server"  style="width: 500px; margin-left: 0.3cm;"></asp:TextBox>
        </div>

    </div>
        </asp:Panel>
    </asp:Panel>

    <br />

    <div class="col-xs-6">
        <h3 class="SignosVitales_ExamenFisico" >Signos Vitales</h3>
           <asp:Panel ID="SignosVitales" class="borders" runat="server">
        <div class="row"> 
                <div class="col-xs-2">PA
                    <asp:TextBox type="number" class="textBoxes" ID="txtPA" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-2">FC
                    <asp:TextBox type="number" class="textBoxes" ID="txtFC" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-2">FR
                    <asp:TextBox type="number" class="textBoxes" ID="txtFR" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-2">Sat.O2
                    <asp:TextBox type="number" class="textBoxes" ID="txtSatO2" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-2">Glicemia
                    <asp:TextBox type="number" class="textBoxes" ID="txtGlicemia" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-2">Temp
                    <asp:TextBox type="number" class="textBoxes" ID="txtTemp" runat="server"></asp:TextBox>
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
                    <asp:CheckBox ID="chkNoDeficitMotor" runat="server"/>No deficit motor
                </asp:Label>
            </div>
             <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkNoDeficitSensitivo" runat="server">
                    <asp:CheckBox ID="chkNoDeficitSensitivo" runat="server"/>No deficit sensitivo
                </asp:Label>
            </div>
             <div class="col-xs-2">
                <asp:Label AssociatedControlID="chkOrientado" runat="server">
                    <asp:CheckBox ID="chkOrientado" runat="server"/>Orientado:Persona,lugar,tiempo
                </asp:Label>
            </div>
            </div>
            <h4>Escala Glasgow</h4>
        </asp:Panel>
        <div>
            <p>Testing</p>
        </div>
        <!--> Testing for git <-->
    </div>
         
    
   
    
    

    
   
</asp:Content>
