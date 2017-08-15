<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.SurveyDtoModel>" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
	CreateSurvey
    
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Encuesta</h2>

    <% using (Html.BeginForm())
       { %>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Datos</legend>
            
            <div class="editor-label">
                <%: Html.Label("Nombre del CSPS") %>
            </div>
            <div class="editor-field">
                
             <%:Html.DropDownList("cpspDdl", Model.CpspList, "Seleccione ...")%>
                <%: Html.ValidationMessageFor(model => model.Id) %>
            </div>
            <br/>
            
            <div id="telephonesDiv" style="display:none">
                  <h2>Información de Contacto:</h2>
            <%: Html.Label("Numeros Telefónicos:") %> 
            <br/>
            <%--   Div to show telephones grid for the selected cpsp--%>
            <div id="telephonepv" ></div>
            </div>
            <br/>
            <div id="emailsDiv" style="display:none">  
                <%: Html.Label("Correo Electrónico:") %> 
                <br/>
                <%--   Div to show emails grid for the selected cpsp--%>
                <div id="emailpv" ></div>
            </div>
       <div class="editor-label">
       <%: Html.LabelFor(model => model.Comentarios) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Comentarios) %>
                <%: Html.ValidationMessageFor(model => model.Comentarios) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombreContacto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreContacto) %>
                <%: Html.ValidationMessageFor(model => model.NombreContacto) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Contesta) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Contesta) %>
                <%: Html.ValidationMessageFor(model => model.Contesta) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>
    
    
 
    

    
    
    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>

