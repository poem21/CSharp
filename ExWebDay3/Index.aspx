<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ExWebDay3.Index" %>

<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script>
        function PageLoad() {
            alert("홍성호");
        }
    </script>
</head>
<body onload="PageLoad();">
    <form id="form1" runat="server">
        <div>
            사용자 아이디 :
            <asp:TextBox ID="TXTID" runat="server"></asp:TextBox>
            <br />
            비밀번호 :
            <asp:TextBox ID="TXTPW" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="로그인" />
            <asp:Button ID="Button2" runat="server" Text="취소" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />

        </div>
        <uc1:Footer runat="server" ID="Footer" />
    </form>
</body>
</html>
