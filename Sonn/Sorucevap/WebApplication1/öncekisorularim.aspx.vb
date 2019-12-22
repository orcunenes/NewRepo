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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim conn As OleDbConnection
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        conn.Open()
        Dim konularisec As String = ("select konu from sorular")
        Dim konularioku As New OleDb.OleDbCommand(konularisec, conn)
        Dreader = konularioku.ExecuteReader
        Dim dongui As Integer
        dongui = -1
        While Dreader.Read()

            DropDownList1.Items.Add(New ListItem(Dreader(0).ToString, Dreader(0).ToString))

        End While

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        TextBox1.ID = "textbox22"

    End Sub
End Class