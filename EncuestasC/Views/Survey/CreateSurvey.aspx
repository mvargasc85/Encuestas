<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.SurveyDtoModel>" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
	CreateSurvey
    
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Encuesta</h2>
<%--
    <% using (Html.BeginForm())
       { %>
        <%: Html.ValidationSummary(true) %>--%>

        <fieldset>
            <legend>Datos</legend>
            <label class="k-label">Nombre del CSPS:</label>
            <br/><br/>
            <div id="cpspDdlDiv" ></div>
            <br/><br/>
            <table>
                <tr>
                    <td><label>Provincia:</label></td>
                    <td><label>Cantón:</label></td>
                    <td><label>Distrito:</label></td>
                    <td><label>Poblado:</label></td>
                </tr>
                <tr>
                    <td><input id="provincias" style="width: 99%;" /></td>
                    <td><input id="canton" disabled="disabled" style="width: 99%;" /></td>
                    <td><input id="distrito" disabled="disabled" style="width: 99%;" /></td>
                    <td><input id="poblado" disabled="disabled" style="width: 99%;" /></td>
                </tr>
                <tr><td colspan="4"></td></tr>
                <tr><td id="telephonesDiv"><label style="font-weight: bold">Información de Contacto:</label></td><td colspan="3"></td></tr>
                <tr><td><label class="k-label">Numeros Telefónicos:</label></td><td colspan="3"></td></tr>
                <tr><td colspan="4"> <div id="telephonepv" style="width: 450px" ></div></td></tr>  
                <tr><td colspan="4"></td></tr>
                <tr><td id="emailsDiv"><label class="k-label">Correo Electronico:</label></td><td colspan="3"></td></tr>
                <tr><td colspan="4">  <div id="emailpv" style="width: 600px"></div></td></tr>
     </table>
            
           
   <%--    <div class="editor-label">
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
            </p>--%>
        </fieldset>

    <%--<% } %>--%>
    
    
 
    

    
    
    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>

