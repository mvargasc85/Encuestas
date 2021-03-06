﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.SurveyDtoModel>" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
	Encuesta
    
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Encuesta</h2>
<%--
    <% using (Html.BeginForm())
       { %>
        <%: Html.ValidationSummary(true) %>--%>
       
        <fieldset style="width: 500px">
            <legend>Datos</legend>
            <label class="k-label">Nombre del CSPS:</label>
            <br/><br/>
            <input id="cpspDdlDiv" name="cpspDdl" />
           
            <br/><br/>
            <table id="cpspInfoTbl" style="display: none">
                <tr><td id="Td1" colspan="3"><label style="font-weight: bold" >Ubicación:</label></td></tr>
                <tr>
                    <td><label>Provincia:</label></td>
                    <td><label>Cantón:</label></td>
                    <td><label>Distrito:</label></td>
                </tr>
                <tr>
                    <td style="width: 170px;"><label id="provinciaIdLbl" ></label></td>
                    <td style="width: 170px;"><label id="cantonIdLbl" ></label></td>
                    <td style="width: 170px;"><label id="distritoIdLbl"></label></td>
                </tr>
                <tr><td colspan="3"></td></tr>
                <tr><td colspan="3"></td></tr>
                <tr><td id="telephonesDiv" colspan="3"><label style="font-weight: bold">Información de Contacto:</label></td></tr>
                <tr><td colspan="3" ><label class="k-label" style="color: midnightblue">Numeros Telefónicos:</label></td></tr>
                <tr><td colspan="3"> <div id="telephonepv" style="width: 100%" ></div></td></tr>  
                <tr><td colspan="3"></td></tr>
                <tr><td colspan="3"></td></tr>
                <tr>
                    <td><label class="k-label" style="color: midnightblue">Contesta la llamada:</label></td>
                    <td><label class="k-radio-label" for="contesta">Si<input type="radio" name="answercallRdbtn" id="contesta" class="k-radio"/></label></td>
                    <td><label class="k-radio-label" for="noContesta">No<input type="radio" name="answercallRdbtn" id="noContesta" class="k-radio"/></label></td>
                </tr>
     </table>
        </fieldset>
    <div id="validatorDiv">
        <fieldset id="callInformationfs" style="width: 500px; display: none">
            
            <legend>Seguimiento de la Llamada</legend>
            <table>
                <tr><td colspan="3"><div class="status" style="color: red; text-align: center; width: 100%"></div></td></tr>
                <tr><td style="width: 170px;"></td><td style="width: 170px;"></td><td style="width: 170px;"></td></tr>
                <tr><td><label>Persona que contesta:</label></td><td colspan="2">
                    <input style="width: 100%" id="contactedPersonDdl" name="contactedPersonDdl" required="required" validationMessage="Debe seleccionar un contacto"/></td>
                    <td><span class="k-invalid-msg" data-for="contactedPersonDdl"></span>
                </td></tr>
                <tr class="otherContact">
                    <td ><label>Nombre contacto:</label></td><td colspan="2"><input class="k-textbox" style="width: 100%" id="contactedPersonName" name="contactedPersonName"  validationMessage="Digite el nombre del contacto" /></td>
                    <td><span class="k-invalid-msg" data-for="contactedPersonName"></span></td>
                </tr>
                <tr class="otherContact">
                    <td><label>Correo contacto:</label></td><td colspan="2"><input class="k-textbox" style="width: 100%" id="contactedPersonEmail" name="contactedPersonEmail"   validationMessage="Digite el email del contacto" /></td>
                    <td><span class="k-invalid-msg" data-for="contactedPersonEmail"></span></td>
                </tr>
                <tr><td>
                    <label>Codigo Presupuestario:</label></td><td colspan="2"><input id="codPresDdl" name="codPresDdl" required="required" validationMessage="Debe seleccionar el código presupuestario"/></td>
                    <td><span class="k-invalid-msg" data-for="codPresDdl"></span></td>
                </tr>
                <tr>
                    <td><label>Proyecto:</label></td>
                    <td colspan="2"><input id="projectIdDdl" name="projectIdDdl" required="required" validationMessage="Debe seleccionar el proyecto"/></td>
                    <td><span class="k-invalid-msg" data-for="projectIdDdl"></span></td>
                </tr>
                <tr>
                    <td><label>Estado del Servicio:</label></td>
                    <td colspan="2"><div id="serviceStatusDdl"></div></td>
                </tr>
                
                <tr><td><label>Observaciones:</label></td><td colspan="2">
                    <%:Html.TextArea("commentsTxt", "", new { @class = "k-textbox", style = "width: 100%;  height:80px" })%>
                   </td></tr>
            </table>
            </fieldset>
            
        </div>
    <br/>

    <div id="bottonsDiv" style="width: 500px; display: none; margin-right: 5px">
        <input id="cancelBtn" class="k-button" value="Cancelar" />
        <input id="saveSurveyBtn" class="k-button" value="Guardar"  />
    </div>

<style type="text/css">
    .otherContact {
        display: none;
    }
</style>
</asp:Content>

