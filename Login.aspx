
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Expense.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <style>
        body {
            min-height: 80vh;
            display: grid;
            place-items: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h2>Expense</h2>
            <asp:Label ID="lblErrorMessage" runat="server" Text="" Visible="false" CssClass="error-message" />
            <div>
                <asp:Label ID="lblName" runat="server" Text="UserName:" />
                <asp:TextBox ID="txtName" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Enter" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
