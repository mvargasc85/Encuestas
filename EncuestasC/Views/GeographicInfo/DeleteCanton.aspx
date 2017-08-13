﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Cantonx>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar Cantón
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar</h2>

    <h3>Esta seguro que desea eliminar este cantón?</h3>
    <fieldset>
        <legend>Datos</legend>
        
        <table>
            <tr>
                <td>
                    <div class="display-label">Id</div>
                </td>
                <td>
                    <div class="display-label">Nombre</div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="display-field"><%= Html.Encode(String.Format("{0:F}", Model.Id)) %></div>
                </td>
                <td> 
                    <div class="display-field"><%= Html.Encode(Model.Nombre) %></div>
                </td>
            </tr>
        </table>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar", "GetAllCantons") %>
        </p>
    <% } %>

</asp:Content>

