<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="öncekisorularim.aspx.vb" Inherits="WebApplication1.öncekisorularim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            konu seçiniz <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Deneme</asp:ListItem>
            </asp:DropDownList>
            <asp:Panel ID="Panel1" runat="server" Width="247px" Visible="true">
                <table>
                    <tr>
                        <td>
                            SORULARINIZ
                        </td>
                        <td>
                            Soruyu Ekle
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox9" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr aria-valuetext="rerer">
                        <td>
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox10" runat="server" Text="Soruyu Ekle" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            </td>
                    </tr>
                </table>
            </asp:Panel> 
           
            <asp:Button ID="Button1" runat="server" Text="Sonraki Sayfa" />
        </div>
    </form>
</body>
</html>
