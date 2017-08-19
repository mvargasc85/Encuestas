<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.CpspDtoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listado de CPSPs
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Listado de CPSPs</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                Nombre
            </th>
           <th>
                Provincia
            </th>
            <th>
                Canton
            </th>
            <th>
                Distrito
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
                <%: item.Provincia.Nombre%>
            </td>
            <td>
                <%: item.Canton.Nombre%>
            </td>
            <td>
                <%: item.Distrito.Nombre%>
            </td>
             <td>
                <%: Html.ActionLink("Editar", "EditCPSP",new { id = item.Id })%> |
                <%: Html.ActionLink("Eliminar", "DeleteCpsp", new { id = item.Id })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nuevo", "CreateCPSP")%>
    </p>

</asp:Content>

