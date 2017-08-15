<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<EncuestasC.Models.Telefonox>>" %>

    <table>
        <tr>
           <th>
                Id
            </th>
            <th>
                Telefono
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
           <td>
                <%: String.Format("{0:F}", item.Id) %>
            </td>
            <td>
                <%: String.Format("{0:F}", item.Telefono1) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    

