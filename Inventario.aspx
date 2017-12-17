<%@ Page Title="Inventario" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inventario.aspx.cs" Inherits="Inventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><%: Title %></h2>
    <asp:Panel ID="pnlInventario" runat="server">
        <div class="row text-style">
            <div class="col-xs-1">
                 Tipo: <asp:DropDownList ID="drpInventarioTipo" class="dropdowns" style="width:70%" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-1">
                 <asp:Button ID="btnBuscarInventario" class="buttons" Text="Buscar Inventario" runat="server" OnClick="btnBuscarInventario_Click"/>
            </div>
            <div class="col-xs-1">
                 <asp:Button ID="btnBuscarTodoInventario" class="buttons" Text="Mostrar Todo" style="margin-left:-55%;" runat="server" OnClick="btnBuscarTodoInventario_Click"/>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-10">
                 <textarea ID="txaHistorial" runat="server"></textarea>
            </div>
        </div>
        <br />
        <div class="row">
             <div class="col-xs-1">
                 <asp:Button ID="btnLlenarInventario" class="buttons" Text="Llenar Inventario" style="margin-left:0.1%" runat="server"/>
            </div>
        </div>
    </asp:Panel>
</asp:Content>

