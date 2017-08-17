<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.EstadoServiciox>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Editar Estado de Servicio
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Estado de Servicio</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
         
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Estado) %>
                <%: Html.ValidationMessageFor(model => model.Estado) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Detalle) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Detalle) %>
                <%: Html.ValidationMessageFor(model => model.Detalle) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "GetAllEstServ")%>
    </div>

</asp:Content>

