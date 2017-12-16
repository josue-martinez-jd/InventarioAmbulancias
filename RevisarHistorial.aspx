<%@ Page Title="Revisar Historial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RevisarHistorial.aspx.cs" Inherits="RevisarHistorial" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:Panel ID="pnlHistorial" runat="server">
    <div class="row text-style">
        <div class="col-lg-5">
             Ingrese Cedula Paciente: <asp:TextBox ID="txtCedula" class="textboxes" type="number" style="width:70%" runat="server"></asp:TextBox>
        </div>
        <div class="col-lg-5">
             <asp:Button ID="btnBuscarHistorial" class="buttons" Text="Buscar Historial" runat="server" OnClick="btnBuscarHistorial_Click"/>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-10">
             <textarea ID="txaHistorial" runat="server"></textarea>
        </div>
    </div>
    </asp:Panel>
    

</asp:Content>
