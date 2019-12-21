<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Giriskayit.aspx.vb" Inherits="WebApplication1.Giriskayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">




        <style>
                body {background-color: powderblue;}
                .id,tr,td{ width:100px; }
        </style>





    <script type="text/javascript">
        function kayitol() {
            document.getElementById("kayitol").style.visibility = "visible";
            document.getElementById("girisyap").style.visibility = "hidden";
            
        }
        function girisyap() {
            document.getElementById("girisyap").style.visibility = "visible";
            document.getElementById("kayitol").style.visibility = "hidden";
            
        }
        function kayitolbutton() {
            var ad = document.getElementById('kayitograd').value;
            var brans = document.getElementById('kayitogrbrans').value;
            var sifre = document.getElementById('kayitogrsifre').value;
            var okuladi = document.getElementById('DropDownListokul').value;
            alert(ad+brans+sifre+okuladi);
        }

    </script>
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
                        <asp:Button ID="Button2" runat="server" Text="Giriş yap" />
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
                        <asp:Button ID="Button1" runat="server" Text="Kayıt ol" OnClientClick="kayitolbutton()" /></td>
                    
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
