<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="son.wellcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <h4>HOŞGELDİNİZ</h4>

            <asp:Button ID="Button1" runat="server" Text="Eklenmiş Sorularım" Height="50px" Width="130px" OnClick="Button1_Click" /><br />
            <asp:Button ID="Button2" runat="server" Text="Yeni Sorular Oluştur" Height="50px" Width="130px" OnClick="Button2_Click" />
        </div>
        </div>
    </form>
</body>
</html>
