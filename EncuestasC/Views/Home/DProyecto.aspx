﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Proyectox>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	DProyecto
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>DProyecto</h2>

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
                Detalle
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { id=item.Id }) %> |
                <%= Html.ActionLink("Details", "Details", new { id=item.Id })%> |
                <%= Html.ActionLink("Delete", "Delete", new { id=item.Id })%>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Id)) %>
            </td>
            <td>
                <%= Html.Encode(item.Nombre) %>
            </td>
            <td>
                <%= Html.Encode(item.Detalle) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

