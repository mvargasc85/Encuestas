<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Cantonx>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	DCanton
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DCanton</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Id
            </th>
            <th>
                Nombre
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Editar", "ECanton", new { id=item.Id }) %> |
                <%= Html.ActionLink("Eliminar", "BCanton", new { id=item.Id })%>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Id)) %>
            </td>
            <td>
                <%= Html.Encode(item.Nombre) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Crear Registro", "CCanton") %>
    </p>

</asp:Content>

