<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<XeroApi.Model.Contact>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th>Contact Name</th>
            <th>Contact Person</th>
            <th>Email</th>
            <th>Telephone</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td><%=Html.Encode(item.Name) %></td>
            <td><%=Html.Encode(string.Format("{0} {1}", item.FirstName, item.LastName)) %></td>
            <td><%=Html.Encode(item.EmailAddress) %></td>
            <td><%=Html.Encode(item.Phones.Where(phone => !string.IsNullOrEmpty(phone.PhoneNumber)).FirstOrDefault())%></td>
        </tr>
    
    <% } %>

    </table>
    
</asp:Content>

