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
   
    <br />
    <div class="row" >
        <h3 style="color:blue;text-align:center">DATOS DEL PACIENTE</h3>
    </div>
    <br />
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
             
             <asp:Label runat="server" style="color:red" AssociatedControlID="chkNoTratamiento"> <asp:CheckBox ID="chkNoTratamiento" runat="server" /> Recordar Ambulancia?</asp:Label>
             <%--<asp:Label runat="server" style="color:red"; AssociatedControlID="chkNoTratamiento"> &nbsp;No Tratamiento</asp:Label>--%>
            <%--<asp:Label style="color:red"; AssociatedControlID="chkNoTratamiento" runat="server"> &nbsp;No Tratamiento</asp:Label>--%>
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
            <q> <asp:CheckBox ID="chkMujer" runat="server" />&nbsp;Mujer</q>
            <q><asp:CheckBox ID="chkHombre" runat="server" />&nbsp;Hombre  </q>
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
            <q style="color:red";> <asp:CheckBox ID="chkAlergias" runat="server" />&nbsp;No Alergias</q>
        </div>

    </div>

        <div class="row" >
        <div class="col-md-2">
            <p > &nbsp;APP: </p>
        </div>

        <asp:Panel ID="APPCheckboxes" runat="server">
            <div class="col-md-2" style="width: 533px;" >
                <q ><asp:CheckBox ID="chkDMelitus" runat="server" />D.Melitus</q>
                &nbsp;&nbsp;&nbsp;
                <q > <asp:CheckBox ID="chkHTA" runat="server" />HTA</q>
                &nbsp;&nbsp;&nbsp;
                <q > <asp:CheckBox ID="chkIAM" runat="server" />IAM</q>
                &nbsp;&nbsp;&nbsp;
                <q > <asp:CheckBox ID="chkAsma" runat="server" />Asma</q>
                &nbsp;&nbsp;&nbsp;
                <q > <asp:CheckBox ID="chkICC" runat="server" />ICC</q>
                &nbsp;&nbsp;&nbsp;
                <q > <asp:CheckBox ID="chkTiroidea" runat="server" />Enf.Tiroidea</q>
                &nbsp;&nbsp;&nbsp;
                <q style="color:red"> <asp:CheckBox ID="chkNoAPP" runat="server" />No APP</q>
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
    <asp:Panel ID=SignosExamenFisico runat="server">
        <div class="row" >
            <div class="col-md-4" >
                <h3 >SIGNOS VITALES</h3>
            </div>

            <div class="col-md-4" >
                <h3 >EXAMEN FISICO</h3>
            </div>
        </div>
    </asp:Panel>
   
    
    

    
   
</asp:Content>
