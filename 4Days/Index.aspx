<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_4Days.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            이름 :&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            성별 :
            <asp:RadioButton ID="rdo01" runat="server" AutoPostBack="True" GroupName="sex" OnCheckedChanged="rdo01_CheckedChanged" Text="남자" />
            <asp:RadioButton ID="rdo2" runat="server" AutoPostBack="True" GroupName="sex" OnCheckedChanged="rdo2_CheckedChanged" Text="여자" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="전송" />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.naver.com">HyperLink</asp:HyperLink><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <asp:Button ID="Button2" runat="server" Text="상세검색" OnClick="Button2_Click" /><p></p>
            
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                이름검색 상세페이지
            </asp:Panel>

            게시판1<br />
            게시판2<br />
        </div>
    </form>
</body>
</html>
