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
            <h4>
                <asp:Button ID="Button1" runat="server" Text="geri" OnClick="Button1_Click" /></h4>
        </div>
        <div style="height: 112px">
            konu seçiniz <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button runat="server" ID="göster" Text="Göster" OnClick="giris_Click" />
            <asp:Panel ID="Panel1" runat="server" Width="255px" Visible="true" Height="243px" >
                <table id="tablo">
                    <tr>
                        <td>
                            SORULARINIZ
                        </td>
                        
                    </tr>
                </table>
            </asp:Panel> 
            <asp:Panel ID="Panel2" runat="server" Width="681px">
            <table>
                <tr><td>
                    <asp:Button ID="girisyap" runat="server" Text="Oyuna Başla" onclick="basla_Click" /></td>
                </tr>
                <tr><td>Konuyu Sil</td><td><asp:Button ID="Button4" runat="server" Text="Konuyu Sil" OnClick="Button4_Click" /></td></tr>

            </table>
            </asp:Panel>
           
            
            <br />

            <asp:Label ID="Label1" runat="server" Text="Label" style="visibility:hidden"></asp:Label>
        </div>
        
    </form>
</body>
</html>
