<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<EncuestasC.Models.Emailx>>" %>

    <table>
        <tr>
           <th>
                Id
            </th>
            <th>
                Correo
            </th>
            <th>
                Nombre
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            
            <td>
                <%: String.Format("{0:F}", item.Id) %>
            </td>
            <td>
                <%: item.Correo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>


