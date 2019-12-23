Imports System.Data.OleDb
Imports System.Data
Public Class öncekisorularim
    Inherits System.Web.UI.Page
    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb"
    Dim ds As DataSet
    Dim Dreader As OleDbDataReader
    Dim conn As OleDbConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Label1.Text = Session("ogretmen")'
        Label1.Text = "Label"

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        conn.Open()
        Dim konularisec As String = ("select konu from sorular")
        Dim konularioku As New OleDb.OleDbCommand(konularisec, conn)
        Dreader = konularioku.ExecuteReader
        While Dreader.Read()
            If DropDownList1.Items.FindByValue(Dreader(0).ToString) Is Nothing Then
                DropDownList1.Items.Add(New ListItem(Dreader(0).ToString, Dreader(0).ToString))
            End If
        End While
        conn.Close()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True

    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        conn.Open()
        Dim sorularisec As String = ("select soru from sorular where [ogretmen] = '" & Label1.Text & "' and [konu] = '" & DropDownList1.SelectedValue & "'")
        Dim sorularioku As New OleDb.OleDbCommand(sorularisec, conn)
        Dreader = sorularioku.ExecuteReader
        Dim textbox As New TextBox
        Dim panel As Panel
        Dim oku(10) As String
        Dim sayi As Integer
        Dim i As Integer
        i = 0

        While Dreader.Read()
            oku(i) = Dreader(0).ToString
            i = i + 1
        End While


        sayi = oku.Length - 1
        For ass As Integer = 1 To sayi
            Dim textbox1 As New TextBox
            textbox1.ID = "textbox" + ass.ToString
            textbox1.Text = oku(ass - 1)
            panel = Panel1.FindControl("paneltb" + ass.ToString)
            panel.Controls.Add(textbox1)
        Next



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        For i As Integer = 1 To 10
            Dim checkbox As CheckBox
            checkbox = Panel1.FindControl("CheckBox" + i.ToString)
            If checkbox.Checked = True Then

                Dim icpanel As Panel
                icpanel = Panel1.FindControl("paneltb" + i.ToString)

                'Dim tb As TextBox
                'tb = icpanel.FindControl("textbox" + i.ToString)
                Dim yenitextbox As New TextBox
                yenitextbox.ID = "textbox" + i.ToString

                Dim panel = Panel1.FindControl("paneltb" + i.ToString)
                Dim str As String
                Dim idstr As String
                idstr = "textbox" + i.ToString
                str = panel.FindControl(idstr).ToString




                Dim soruekle1 As String = "INSERT INTO tablo2(ogretmen,konu,soru) VALUES (@ogretmenad,@konuadi,@soru)"
                Dim cmd As New OleDb.OleDbCommand(soruekle1, conn)
                cmd.Parameters.AddWithValue("@ogretmenad", Label1.Text)
                cmd.Parameters.AddWithValue("@konuadi", DropDownList1.SelectedValue)
                cmd.Parameters.AddWithValue("@soru", Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End If
        Next


    End Sub
End Class