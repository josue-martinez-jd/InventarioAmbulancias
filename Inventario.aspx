<%@ Page Title="Inventario" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inventario.aspx.cs" Inherits="Inventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><%: Title %></h2>
    <asp:Panel ID="pnlInventario" runat="server">
        <div class="row text-style">
            <div class="col-xs-1">
                 Tipo: <asp:DropDownList ID="drpInventarioTipo" class="dropdowns" style="width:70%" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-1">
                 <asp:Button ID="btnBuscarInventario" class="buttons" Text="Buscar Inventario" runat="server"/>
            </div>
            <div class="col-xs-1">
                 <asp:Button ID="btnBuscarTodoInventario" class="buttons" Text="Mostrar Todo" style="margin-left:-55%;" runat="server"/>
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

