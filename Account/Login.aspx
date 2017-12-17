<%@ Page Title="Inicio de Sesion" Language="C#" MasterPageFile="Login.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                   
                  
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="lblErrorInicioSesion"  />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtUsuario" CssClass="col-md-2 control-label">Ambulancia</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsuario"
                                CssClass="text-danger" ErrorMessage="El nombre de ambulancia es requerido" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtContrasena" CssClass="col-md-2 control-label">Contrasena</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtContrasena" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtContrasena" CssClass="text-danger" ErrorMessage="La contrasena es requerida" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <div class="checkbox" style="visibility:hidden;">
                                <asp:CheckBox runat="server" ID="chkRecordar"  />
                                <asp:Label runat="server" AssociatedControlID="chkRecordar">Recordar Ambulancia?</asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn" Text="Iniciar Sesion" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                
            </section>
        </div>
    </div>
</asp:Content>

