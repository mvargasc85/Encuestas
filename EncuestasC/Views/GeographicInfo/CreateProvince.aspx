<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Provinciax>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Agregar Nueva Provincia
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CreateProvince</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Datos a Completar</legend>
            
          <div class="editor-label">
                <%= Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Nombre) %>
                <%= Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Regresar", "GetAllProvinces") %>
    </div>

</asp:Content>

