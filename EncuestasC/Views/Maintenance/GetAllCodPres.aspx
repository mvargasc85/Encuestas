<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.CodigoPresupuestariox>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	GetAllCodPres
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>GetAllCodPres</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                Codigo
            </th>
            <th>Acciones</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
           
            <td>
                <%: item.Id %>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
             <td>
                <%: Html.ActionLink("Editar", "EditCodPres", new { id = item.Id })%> |
               <%: Html.ActionLink("Eliminar", "DeleteCodPres", new { id=item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Registro", "CreateCodPres") %>
    </p>

</asp:Content>

