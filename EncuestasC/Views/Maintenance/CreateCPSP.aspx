<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.CpspDtoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	GetAllCPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>GetAllCPSP</h2>

    <table>
        <tr>
            <th></th>
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
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
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
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

