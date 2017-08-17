<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.CodigoPresupuestariox>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditCodPres
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EditCodPres</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
              
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Volver", "GetAllCodPres")%>
    </div>

</asp:Content>

