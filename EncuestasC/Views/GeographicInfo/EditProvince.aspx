<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Provinciax>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditProvince
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Provincias</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos a editar</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Nombre) %>
                <%= Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            <br/>
            <div>
                <input type="submit" value="Guardar" />
            </div>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Regresar", "GetAllProvinces")%>
    </div>

</asp:Content>

