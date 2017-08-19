<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<EncuestasC.Models.CpspDtoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Editar CPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar CPSP</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos</legend>
            <%: Html.HiddenFor(model => model.Id,new {@id = "cpspToEditId"}) %>
            <table>
               <tr>
                   <td>  <%: Html.LabelFor(model => model.Nombre)%></td>
                   <td>  <%: Html.TextBoxFor(model => model.Nombre,new { @id = "cpspName" , @style = "width:200px" , @class = "k-textbox" })%></td>
                   <td> <%: Html.ValidationMessageFor(model => model.Nombre) %></td>
               </tr>
               
               <tr>
                   <td> <%: Html.LabelFor(model => model.ProvinciaId) %></td>
                    <td><input id="provinciaDdl" style="width: 170px;" value=" <%: Model.ProvinciaId%>" /></td>
                    <td> <%: Html.ValidationMessageFor(model => model.ProvinciaId)%></td>
               </tr>
                <tr>
                    <td>  <%: Html.LabelFor(model => model.CantonId) %></td>
                    <td><input id="cantonDdl" style="width: 170px;" value=" <%: Model.CantonId%>"/></td>
                    <td><%: Html.ValidationMessageFor(model => model.CantonId)%></td>
                </tr>
                <tr>
                    <td><%: Html.LabelFor(model => model.DistritoId) %></td>
                    <td><input id="distritoDdl"  style="width: 170px;" value=" <%: Model.DistritoId%>"/></td>
                    <td><%: Html.ValidationMessageFor(model => model.DistritoId)%></td>
                </tr>
                <tr>
                    
                    <td><input id="cancelCpspBtn" class="k-button" value="Cancelar" /></td>
                    <td> <input id="saveCpspBtn" class="k-button" value="Actualizar" /></td>
                    <td></td>
                </tr>
            </table>
    
          
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "GetAllCPSP") %>
    </div>
</asp:Content>

