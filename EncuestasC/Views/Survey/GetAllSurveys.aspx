<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<EncuestasC.Models.Encuestax>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	GetAllSurveys
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>GetAllSurveys</h2>

    <table>
        <tr>
            
            <th>
                Id
            </th>
            <th>
                CPSP
            </th>
            <th>
                ContestaLlamada
            </th>
            <th>
                Nombre Contacto
            </th>
            <th>
                Email
            </th>
            <th>
                Cod. Presupuestario
            </th>
            <th>
                Id Proyecto
            </th>
            <th>
                Estado Servicio
            </th>
            <th>
                Comentarios
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            
            <td>
                <%: String.Format("{0:F}", item.Id) %>
            </td>
            <td>
                <%: item.IdCPSP %>
            </td>
            <td>
                <%: item.ContestaLlamada %>
            </td>
            <td>
                <%: item.NombreContacto %>
            </td>
            <td>
                <%: item.IdEmail %>
            </td>
            <td>
                <%: item.IdCodigoPresupuestario %>
            </td>
            <td>
                <%: item.IdProyecto %>
            </td>
            <td>
                <%: item.IdEstadoServicio %>
            </td>
            <td>
                <%: item.Comentarios %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Hacer Encuesta", "CreateSurvey") %>
    </p>

</asp:Content>

