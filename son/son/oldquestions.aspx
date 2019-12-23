<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oldquestions.aspx.cs" Inherits="son.oldquestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
       .tablo,tr,td{
           width:150px;
       }
        </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body runat="server" id="body">
    <form id="form1" runat="server">
        <div>
            konu seçiniz <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button runat="server" Text="Göster" OnClick="giris_Click" />
            <asp:Panel ID="Panel1" runat="server" Width="205px" Visible="true" Height="243px">
                <table id="tablo">
                    <tr>
                        <td>
                            SORULARINIZ
                        </td>
                        
                    </tr>
                </table>
            </asp:Panel> 
           
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Gönder" OnClick="Button2_Click" />
        </div>
        
    </form>
</body>
</html>
