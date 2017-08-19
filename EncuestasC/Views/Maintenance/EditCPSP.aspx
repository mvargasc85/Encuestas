<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.CpspDtoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditCPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EditCPSP</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ProvinciaId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ProvinciaId)%>
                <%: Html.ValidationMessageFor(model => model.ProvinciaId)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CantonId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CantonId)%>
                <%: Html.ValidationMessageFor(model => model.CantonId)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DistritoId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.DistritoId)%>
                <%: Html.ValidationMessageFor(model => model.DistritoId)%>
            </div>
           creo qye ya
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

