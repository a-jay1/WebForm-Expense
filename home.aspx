<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Expense.home" %>

<!DOCTYPE html>

<html >
<head >
     <title>Home page</title>
     <style>
        body {
            min-height: 80vh;
            display: grid;
            place-items: center;
        }
        .container {
            display: grid;
            grid-template-columns: repeat(2, 1fr);
        }
    </style>
</head>
<body>
    <div>
        <div>
            <span>Welcome ! </span>
            <asp:Label ID="userName" runat="server" Text="" Visible="true" CssClass="error-message" />
            <span>your total expense is</span>
            <asp:Label ID="totalCost" runat="server" Text="" Visible="true" CssClass="error-message" />
        </div>
            <br /><br /><br /><br />
        <form id="form1" runat ="server">
            <div class="container">
                <div class="a">
            <div>
                <asp:Label ID="lblName" runat="server" Text="Amount" />
                <asp:TextBox ID="amount" runat="server" type="text" />
            </div>

            <div>
                <asp:Label ID="dateName" runat="server" Text="Date  " />
                <asp:TextBox ID="date_" runat="server" type="date" />
            </div>

            <div>
                <asp:Label ID="sessionLabel" runat="server" AssociatedControlID="sessionDropDown" Text="Choose session" />
                <asp:DropDownList ID="SessionDropDown" runat="server">
                <asp:ListItem Text="Morning" Value="Morning" />
                <asp:ListItem Text="Afternoon" Value="Afternoon" />
                <asp:ListItem Text="Evening" Value="Evening" />
                <asp:ListItem Text="Night" Value="Night" />
                </asp:DropDownList>
            </div>

            <div>
                <asp:Label ID="lblmsg" runat="server" Text="message" />
                <asp:TextBox ID="msg" runat="server" type="text" />
            </div>

                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />

        </div>

        <div class="b">
            <div>
                <asp:Label ID="Label1" runat="server" Text="year" />
                <asp:TextBox ID="year" runat="server" type="text" />
                <asp:Button ID="Button1" runat="server" Text="Search" OnClick="btnSearch_yearClick" />
                <asp:Label ID="Label4" runat="server" Text="" Visible="false" CssClass="error-message" />
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="month" />
                <asp:TextBox ID="month" runat="server" type="text" />
                <asp:Button ID="Button2" runat="server" Text="Search" OnClick="btnSearch_monthClick" />
                <asp:Label ID="Label5" runat="server" Text="" Visible="false" CssClass="error-message" />
            </div>

            <div>
                <asp:Label ID="Label3" runat="server" Text="Date  " />
                <asp:TextBox ID="date" runat="server" type="date" />
                <asp:Button ID="Button3" runat="server" Text="Search" OnClick="btnSearch_dateClick" />
                <asp:Label ID="Label6" runat="server" Text="" Visible="false" CssClass="error-message" />
            </div>
        </div>
            </div>
        </form>
    </div>
</body>
</html>
