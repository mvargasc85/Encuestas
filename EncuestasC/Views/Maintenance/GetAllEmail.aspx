<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Emailx>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Emails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Emails</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                Nombre
            </th>
            <th>
                Correo
            </th>
            <th>
                CPSP
            </th>
            <th></th>
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
                <%: item.Correo %>
            </td>
            <td>
                <%: item.IdCPSP %>
            </td>
             <td>
                <%: Html.ActionLink("Editar", "EditEmail", new { id=item.Id }) %> |
              
                <%: Html.ActionLink("Eliminar", "DeleteEmail", new { id=item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nuevo", "CreateEmail") %>
    </p>

</asp:Content>

