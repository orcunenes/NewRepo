<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginregister.aspx.cs" Inherits="son.giriskayitt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:left">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Giriş Yap" groupname="reglog" Checked="true" onchange="girisyap()" />
            <table id="girisyap" >
               
                <tr>
                    <td>Öğretmen Adı:</td><td><asp:TextBox ID="giriskadi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Şifre:</td><td><asp:TextBox ID="girissifre" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="girisyap_Click" />
                    </td>
                </tr>
            </table>
        </div>





        
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="Kayıt Ol" groupname="reglog" onchange="kayitol()"/>
                    
        <div>
            <table id="kayitol" >
                
                <tr>
                    <td>Okul Adı:</td>
                    <td>
                        <asp:DropDownList ID="DropDownListokul" runat="server"><asp:ListItem>Medipol Üniversitesi</asp:ListItem><asp:ListItem>Galatasaray Lisesi</asp:ListItem></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Öğretmen Adı:</td>
                    <td>
                        <asp:TextBox ID="kayitograd" runat="server" value="adınız"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Branş:</td>
                    <td>
                        <asp:TextBox ID="kayitogrbrans" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Şifre:</td>
                    <td>
                        <asp:TextBox ID="kayitogrsifre" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td >
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" /></td>
                    
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
