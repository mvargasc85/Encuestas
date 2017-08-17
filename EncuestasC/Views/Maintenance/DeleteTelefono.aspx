<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Telefonox>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar Telefono
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Telefono</h2>

    <h3>Favor confirmar la eliminación</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Id</div>
        <div class="display-field"><%: Model.Id %></div>
        
        <div class="display-label">Telefono1</div>
        <div class="display-field"><%: Model.Telefono1 %></div>
        
        <div class="display-label">IdCPSP</div>
        <div class="display-field"><%: Model.IdCPSP %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Volver", "GetAllTelefono") %>
        </p>
    <% } %>

</asp:Content>

