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

    <div class="row">
        <div class="col-md-4" >  
         <p> &nbsp; Medico o TEM:  </p>
        </div>
        <div class="col-md-4" >
         <asp:TextBox class="textBoxes" ID="txtMedico" runat="server" Width="110px" ></asp:TextBox>  
        </div>

        <div class="col-md-4">
         <p> &nbsp;&nbsp;&nbsp;Paramedico: </p>
        </div>
         <div class="col-md-4">
             <asp:TextBox class="textBoxes" ID="txtParamedico" runat="server"  Width="110px"></asp:TextBox>
         </div>
         </div>
</asp:Content>
