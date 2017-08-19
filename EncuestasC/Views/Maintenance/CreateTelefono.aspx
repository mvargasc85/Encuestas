<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Telefonox>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Crear Telefono
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear Telefono</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Datos</legend>
            
           
            
            <div class="editor-label">
                Telefono
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Telefono1) %>
                <%: Html.ValidationMessageFor(model => model.Telefono1) %>
            </div>
            
            <div class="editor-label">
                CPSP
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCPSP) %>
                <%: Html.ValidationMessageFor(model => model.IdCPSP) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Volver", "getAllTelefono")%>
    </div>

</asp:Content>

