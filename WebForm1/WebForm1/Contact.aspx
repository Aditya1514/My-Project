<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>

    <div>
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server"  />
        <asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="txtName" ErrorMessage="*" />
    </div>
     <div>
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" />
    </div>
    <div>
        <label>Age</label>
        <asp:TextBox ID="txtAge" runat="server" />
    </div>

    <div>
        <label>Your Favorite Sport:</label>
        <asp:DropDownList ID="ddlSport" runat="server">
            <asp:ListItem Text="Cricket" Value="Cricket"></asp:ListItem>
            <asp:ListItem Text="VolleyBall" Value="VolleyBall"></asp:ListItem>
            <asp:ListItem Text="FootBall" Value="FootBall"></asp:ListItem>
            <asp:ListItem Text="Kabaddi" Value="Kabbadi"></asp:ListItem>
        </asp:DropDownList>
    </div>

    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Info" OnClick="btnSubmit_Click" />
    </div>
    <div>
        Welcome to Contact Page
    </div>

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
