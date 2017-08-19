<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.CpspDtoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Eliminar CPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar CPSP</h2>

    <h3>Seguro que desea eliminar este CPSP?</h3>
    <fieldset>
        <legend>Datos</legend>
        
        <table>
            <tr>
                <td><div class="display-label">Id</div></td>
                <td><div class="display-label">Nombre</div></td>
                <td><div class="display-label">Provincia</div></td> 
                <td><div class="display-label">Canton</div></td> 
                <td><div class="display-label">Distrito</div></td>
            </tr>
            <tr>
                <td><div class="display-field"><%: Model.Id %></div></td>
                <td> <div class="display-field"><%: Model.Nombre %></div></td> 
                <td> <div class="display-field"><%: Model.Provincia.Nombre %></div></td>
                <td> <div class="display-field"><%: Model.Canton.Nombre %></div></td> 
                <td><div class="display-field"><%: Model.Distrito.Nombre %></div></td>
            </tr>
        </table>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Regresar", "GetAllCPSP") %>
        </p>
    <% } %>

</asp:Content>

