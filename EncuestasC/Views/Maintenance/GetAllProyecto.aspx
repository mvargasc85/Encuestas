<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Proyectox>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Proyectos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Proyectos</h2>

    <table>
        <tr>
           
            <th>
                Id
            </th>
            <th>
                Nombre
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
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Detalle %>
            </td>
             <td>
                <%: Html.ActionLink("Editar", "EditProyecto", new { id=item.Id }) %> |
                
                <%: Html.ActionLink("Eliminar", "DeleteProyecto", new { id=item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo", "CreateProyecto") %>
    </p>

</asp:Content>

