<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Cantonx>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Cantones
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Cantones</h2>

    <table>
        <tr>
           
            <th>
                Id
            </th>
             <th>
                Id Provincia
            </th>
            <th>
                Nombre
            </th> 
            <th></th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: String.Format("{0:F}", item.Id) %>
            </td>
            <td>
                <%: String.Format("{0:F}", item.IdProvincia) %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "EditCanton", new { id=item.Id }) %> |
                <%: Html.ActionLink("Eliminar", "DeleteCanton", new { id=item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nuevo", "CreateCanton") %>
    </p>

</asp:Content>

