<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Write.aspx.cs" Inherits="WebTest.Write" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            글제목 :
            <asp:TextBox ID="TXTBNM" runat="server" Width="453px"></asp:TextBox>
        </div>
        <div>
            본문 :
            <asp:TextBox ID="TXTBODY" runat="server" TextMode="MultiLine" Rows="8" Width="473px"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="BTNNEW" runat="server" Text="-" OnClick="BTNNEW_Click" /><asp:Button ID="BTNCAN" runat="server" Text="이전목록" OnClick="BTNCAN_Click" />
        </div>
        <asp:HiddenField ID="itype" runat="server" />
        <asp:HiddenField ID="ibid" runat="server" />
    </form>
</body>
</html>
