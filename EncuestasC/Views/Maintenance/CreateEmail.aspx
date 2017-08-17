<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Emailx>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Crear Email
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear Email</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
           
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Correo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Correo) %>
                <%: Html.ValidationMessageFor(model => model.Correo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCPSP) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCPSP) %>
                <%: Html.ValidationMessageFor(model => model.IdCPSP) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Volver", "getAllEmail") %>
    </div>

</asp:Content>

