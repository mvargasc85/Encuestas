<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.EstadoServiciox>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Estados de Servicio
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Estados de Servicio</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Id
            </th>
            <th>
                Estado
            </th>
            <th>
                Detalle
            </th>
            <th>Acciones</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            
            <td>
                <%: item.Id %>
            </td>
            <td>
                <%: item.Estado %>
            </td>
            <td>
                <%: item.Detalle %>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "EditEstServ", new { id=item.Id }) %> |
               
                <%: Html.ActionLink("Eliminar", "DeleteEstServ", new { id = item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Registro", "CreateEstServ")%>
    </p>

</asp:Content>

