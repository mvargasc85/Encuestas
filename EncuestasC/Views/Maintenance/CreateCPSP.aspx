<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.CpspDtoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Agregar nuevo CPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Agregar nuevo CPSP</h2>
    <fieldset>
        <legend> Datos</legend>
        <table>
            <tr>
                <td><label>Nombre del CPSP:</label></td>
                <td colspan="2"><input class="k-textbox" style="width: 100%" id="cpspName" /></td>
            </tr>
            <tr><td id="Td1" colspan="3"><label style="font-weight: bold" >Ubicación:</label></td></tr>
                    <tr>
                        <td><label>Provincia:</label></td>
                        <td><label>Cantón:</label></td>
                        <td><label>Distrito:</label></td>
                    </tr>
                   <tr>
                        <td><input id="provinciaDdl" style="width: 170px;" /></td>
                        <td><input id="cantonDdl" style="width: 170px;" /></td>
                        <td><input id="distritoDdl"  style="width: 170px;" /></td>
                   
                    </tr>
   
      </table>
  </fieldset>
    <p>
        <input id="cancelCpspBtn" class="k-button" value="Cancelar" />
        <input id="saveCpspBtn" class="k-button" value="Guardar" />
     
    </p>

</asp:Content>

