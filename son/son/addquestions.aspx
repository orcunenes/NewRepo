<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addquestions.aspx.cs" Inherits="son.addquestions" %>

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
            
            document.getElementById('hiddenlabel').innerText = sorui;
            document.getElementById('container').innerHTML = document.getElementById('container').innerHTML
                + '<tr><td>Soru' + sorui + '</td >'
                + '<td><input type="text" value="soru1" id="soru' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap1" id="cevap' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap2" id="yanliscevapbir' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap3" id="yanliscevapiki' + sorui + '" /></td>'
                + '<td><input type="text" value="cevap4" id="yanliscevapuc' + sorui + '" /></td></tr >';
            sorui = sorui + 1;
            
            */
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
                <tr><td>
                    <asp:Button ID="Button2" runat="server" Text="geri" OnClick="Button2_Click" Width="92px" />
                    </td>
                    <td>Ders Adı:</td>
                    <td><asp:DropDownList ID="DropDownListders" runat="server">
                            <asp:ListItem>Matematik</asp:ListItem>
                            <asp:ListItem>Türkçe</asp:ListItem>
                            <asp:ListItem>Coğrafya</asp:ListItem>
                            <asp:ListItem>ingilizce</asp:ListItem>
                        </asp:DropDownList></td>
                    <td>KONU:</td><td><asp:TextBox ID="konuadi" runat="server"></asp:TextBox></td>
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
                    <td><asp:TextBox ID="soru1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc1" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc2" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc3" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki4" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc4" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki5" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc5" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki6" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc6" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki7" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc7" runat="server"></asp:TextBox></td>

               </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki8" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc8" runat="server"></asp:TextBox></td>

                    </tr>
                <tr>
                    <td>Soru1</td>
                    <td><asp:TextBox ID="soru9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki9" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc9" runat="server"></asp:TextBox></td>

               </tr>
               <tr>
                    <td>Soru10</td>
                    <td><asp:TextBox ID="soru10" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="dogru10" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapbir10" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapiki10" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="yanliscevapuc10" runat="server"></asp:TextBox></td>

               </tr>
            </table>
            </div>
            
             <%--   <input type="button" value="soru ekle" onclick="soruekle()"/><asp:RadioButton ID="otomatikdoldur" runat="server" Text="Yanlış Cevapları Otomatik Doldur" />
&nbsp;<br />--%>
        <br />
        <asp:Label ID="hiddenlabel" runat="server" Text="hiddenlabel"></asp:Label><asp:Label ID="hiddenogretmen" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Sorularımı Gönder" OnClick="Button1_Click" />
    </form>
</body>
</html>
