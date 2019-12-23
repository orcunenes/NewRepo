<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="öncekisorularim.aspx.vb" Inherits="WebApplication1.öncekisorularim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
       .tablo,tr,td{
           width:150px;
       }
        .auto-style1 {
            height: 25px;
        }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body runat="server" id="body">
    <form id="form1" runat="server">
        <div>
            konu seçiniz <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button runat="server" Text="Göster" OnClick="Unnamed1_Click" />
            <asp:Panel ID="Panel1" runat="server" Width="639px" Visible="true">
                <table id="tablo">
                    <tr>
                        <td>
                            SORULARINIZ
                        </td>
                        <td>
                            Soruyu Ekle
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Panel ID="Paneltb1" runat="server"></asp:Panel>
                        </td>
                        <td class="auto-style1">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb2" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb3" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb4" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb5" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb6" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb7" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb8" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb9" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox9" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="Paneltb10" runat="server"></asp:Panel>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox10" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    
                </table>
            </asp:Panel> 
           
            <asp:Button ID="Button1" runat="server" Text="Sonraki Sayfa" /><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Gönder" />
        </div>
        
    </form>
</body>
</html>
