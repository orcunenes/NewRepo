Imports System.Data.OleDb
Imports System.Data
Public Class sorular
    Inherits System.Web.UI.Page

    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb"
    Dim ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As OleDbConnection
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        Dim i As String = "select sorusayisi From sorulartablosayisi "
        Dim cmd As New OleDb.OleDbCommand(i, conn)
        conn.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim dongu As String
        Dim tablosayisi As Integer
        While reader.Read()

            dongu = dongu + 1


        End While
        MsgBox(dongu)
        While reader.Read()
            tablosayisi = reader(dongu).ToString()

        End While


        cmd.Dispose()
        conn.Close()
        Dim conn2 As OleDbConnection
        conn2 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        Dim tabloolustur As String = "CREATE TABLE @tablename (Ders nvarchar(50),konu nvarchar(50), soru nvarchar(50),dcevap nvarchar(50),ycevap1 nvarchar(25),ycevap2 nvarchar(25),ycevap3 nvarchar(25));"
        Dim komut2 As New OleDb.OleDbCommand(tabloolustur, conn2)
        komut2.Parameters.AddWithValue("@tablename", TextBox1.Text)
        conn2.Open()


        komut2.ExecuteNonQuery()
        conn2.Close()

    End Sub
End Class