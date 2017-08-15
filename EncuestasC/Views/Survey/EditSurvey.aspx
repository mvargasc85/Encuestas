<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Encuestax>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditSurvey
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EditSurvey</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Id) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Id, String.Format("{0:F}", Model.Id)) %>
                <%: Html.ValidationMessageFor(model => model.Id) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ContestaLlamada) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ContestaLlamada) %>
                <%: Html.ValidationMessageFor(model => model.ContestaLlamada) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombreContacto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreContacto) %>
                <%: Html.ValidationMessageFor(model => model.NombreContacto) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Comentarios) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Comentarios) %>
                <%: Html.ValidationMessageFor(model => model.Comentarios) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

