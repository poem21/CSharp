<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="subTitle.ascx.cs" Inherits="WebTest.Common.subTitle" %>
<div class="container">
    <table class="table table-bordered" style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="subTit" runat="server" Text="-"></asp:Label>
            </td>
            <td style="width: 80px; background-color: whitesmoke;">검색열
            </td>
            <td style="width: 80px;">
                <asp:TextBox ID="TXTSEARCH" runat="server"></asp:TextBox>
            </td>
            <td style="width: 80px;">
                <asp:Button ID="BTNSEARCH" runat="server" Text="검색" OnClick="BTNSEARCH_Click" />
            </td>
            <td style="width: 80px;">
                <asp:Button ID="BTNWRITE" CssClass="btn btn-danger" Width="100%" runat="server" Text="작성" />
                <asp:HiddenField ID="btnnav" runat="server" />
            </td>
        </tr>
    </table>
</div>
