<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.CpspDtoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	GetAllCPSP
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>GetAllCPSP</h2>
    
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
   

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

