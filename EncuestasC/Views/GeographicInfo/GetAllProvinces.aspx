<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Provinciax>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Provincias
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Provincias</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                Nombre
            </th>
            <th></th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Id)) %>
            </td>
            <td>
                <%= Html.Encode(item.Nombre) %>
            </td>
            <td>
                <%= Html.ActionLink("Editar", "EditProvince", new { id = item.Id })%> |
                <%= Html.ActionLink("Eliminar", "DeleteProvince", new { id = item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Crear Nueva", "CreateProvince") %>
    </p>

</asp:Content>

