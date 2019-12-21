<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="sorular.aspx.vb" Inherits="WebApplication1.sorular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        
        sorui = 2;
       
        function soruekle() {

            /*document.getElementById('container').innerHTML =
            document.getElementById('container').innerHTML
            +'<a>soru' + (sorui)+'</a>'
            + '<input type="text" name="soru' + (sorui) + '">'
            + '<input type="text" name="cevap' + (sorui) + '">'
            + '<input type="text" name="yanliscevap' + (sorui) + '">'
            + '<input type="text" name="yanliscevap' + (sorui) + '">'
            + '<input type="text" name="yanliscevap' + (sorui) + '"><br>'
            ;
            sorui=sorui + 1;
            */
            document.getElementById('hiddenlabel').innerText = sorui;
            document.getElementById('container').innerHTML = document.getElementById('container').innerHTML
                + '<tr><td>Soru'+sorui+'</td >'
                +'<td><input type="text" value="soru1" name="soru'+sorui+'" /></td>'
                + '<td><input type="text" value="cevap1" name="cevap'+sorui+'" /></td>'
                + '<td><input type="text" value="cevap2" name="yanliscevap' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap3" name="yanliscevap' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap4" name="yanliscevap' + sorui +'" /></td></tr >'
            sorui = sorui + 1;
            
        }
    </script>
    <style>
         input[type="text"]
        {
            width:100px;
        }
         .top{
             border:solid 1px grey;
         }
         td{
             width:100px;
         }
         
         
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div id="topdiv" >
            <table id="top" >
                <tr>
                    <td>Ders Adı:</td>
                    <td><asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Türkçe</asp:ListItem>
                            <asp:ListItem>Coğrafya</asp:ListItem>
                            <asp:ListItem>ingilizce</asp:ListItem>
                        </asp:DropDownList></td>
                    <td>KONU:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td colspan="2" style="width:200px">Sorularınızı giriniz:</td></tr>
                <tr>
                    <td></td>
                    <td>Soru</td>
                    <td>Doğru Cevap</td>
                    <td>Yanlış Cevap 1</td>
                    <td>Yanlış Cevap 2</td>
                    <td>Yanlış Cevap 3</td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><input type="text" value="soru1" name="soru1" /></td>
                    <td><input type="text" value="cevap1" name="cevap1"/></td>
                    <td><input type="text" value="cevap2" name="yanliscevap1"/></td>
                    <td><input type="text" value="cevap3" name="yanliscevap2"/></td>
                    <td><input type="text" value="cevap4" name="yanliscevap3" /></td>

               </tr>

            </table>

                


            </div>
            <div ><table id="container"></table></div>
            <input type="button" value="soru ekle" onclick="soruekle()"/><asp:RadioButton ID="otomatikdoldur" runat="server" Text="Yanlış Cevapları Otomatik Doldur" />
&nbsp;<br />
        <br />
        <asp:Label ID="hiddenlabel" runat="server" Text="hiddenlabel"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Sorularımı Gönder" />
    </form>
</body>
</html>
