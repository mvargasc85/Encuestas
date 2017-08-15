<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Cantonx>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Agregar nuevo Cantón
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Agregar nuevo Cantón</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
           <tr>
            <th>
            <%: Html.LabelFor(model => model.IdProvincia)%>
            </th>
            <th>
                <%: Html.LabelFor(model => model.Nombre) %>
                </th>
                </tr>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdProvincia)%>
                <%: Html.TextBoxFor(model => model.Nombre)%>
                <%: Html.ValidationMessageFor(model => model.IdProvincia)%>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "GetAllCantons") %>
    </div>

</asp:Content>

