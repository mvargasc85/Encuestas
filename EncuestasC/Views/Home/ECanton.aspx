<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.Cantonx>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ECanton
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ECanton</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
           
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Nombre) %>
                <%= Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

