<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebTest.Index" %>

<%@ Register Src="~/Common/subTitle.ascx" TagPrefix="uc1" TagName="subTitle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>웹폼 프로그램 테스트</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="table table-bordered" style="width:100%">
                <tr>
                    <td>
                        자유게시판
                    </td>
                    <td style="width:80px; background-color:whitesmoke;">
                        검색열
                    </td>
                    <td style="width:80px;">
                        <asp:TextBox ID="TXTSEARCH" runat="server"></asp:TextBox>
                    </td>
                    <td style="width:80px;">
                        <asp:Button ID="BTNSEARCH" runat="server" Text="검색" />
                    </td>
                    <td style="width:80px;">
                        <asp:Button ID="BTNWRITE" CssClass="btn btn-danger" Width="100%" runat="server" Text="작성" OnClick="BTNWRITE_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <uc1:subTitle runat="server" ID="subTitle" />
        <div class="container">
            <asp:Table ID="TBLLIST" runat="server" CssClass="table table-bordered table-hover" Width="100%"></asp:Table>
        </div>
    </form>
</body>
</html>
