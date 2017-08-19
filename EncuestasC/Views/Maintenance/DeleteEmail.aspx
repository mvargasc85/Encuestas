<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Emailx>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar Email
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Email</h2>

    <h3>Seguro que desea eliminar el siguiente Email?</h3>
    <fieldset>
        <legend>Datos</legend>
        
        <table>
            <tr>
                <td><div class="display-label">Id</div></td>
                <td><div class="display-label">Nombre</div></td>
                <td><div class="display-label">Correo</div></td> 
                <td><div class="display-label">CPSP</div></td> 
            </tr>
            <tr>
                <td><div class="display-field"><%: Model.Id %></div></td>
                <td> <div class="display-field"><%: Model.Nombre %></div></td> 
                <td> <div class="display-field"><%: Model.Correo %></div></td>
                <td> <div class="display-field"><%: Model.IdCPSP %></div></td> 
            </tr>
        </table>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		   
		    <%: Html.ActionLink("Volver", "GetAllEmail") %> |
            <input type="submit" value="Eliminar" /> 
        </p>
    <% } %>

</asp:Content>

