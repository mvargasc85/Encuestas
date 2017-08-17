<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Telefonox>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Telefono
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Telefono</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                Telefono1
            </th>
            <th>
                IdCPSP
            </th>
            <th>Acciones</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
         
            <td>
                <%: item.Id %>
            </td>
            <td>
                <%: item.Telefono1 %>
            </td>
            <td>
                <%: item.IdCPSP %>
            </td>
               <td>
                <%: Html.ActionLink("Editar", "EditTelefono", new { id=item.Id }) %> |
              
                <%: Html.ActionLink("Eliminar", "DeleteTelefono", new { id = item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Ingresar Registro", "CreateTelefono") %>
    </p>

</asp:Content>

