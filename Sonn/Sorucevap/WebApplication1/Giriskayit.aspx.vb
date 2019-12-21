
Imports System.Data.OleDb
Imports System.Data
Public Class Giriskayit
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



        Dim sql As String = "INSERT INTO tablo1(ogretmenadi,okuladi,brans,sifre) VALUES (@ogretmenadi, @okuladi,@brans,@sifre)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@ogretmenadi", kayitograd.Text)
        cmd.Parameters.AddWithValue("@okuladi", DropDownListokul.SelectedValue)
        cmd.Parameters.AddWithValue("@brans", kayitogrbrans.Text)
        cmd.Parameters.AddWithValue("@sifre", kayitogrsifre.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()




    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As OleDbConnection
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        ds = New DataSet
        adapter = New OleDbDataAdapter("select * from tablo1 where [ogretmenadi] = '" & giriskadi.Text &
                                       "' and [sifre] = '" & girissifre.Text & "'", conn)
        adapter.Fill(ds, "tablo1")

        If ds.Tables("tablo1").Rows.Count > 0 Then
            MsgBox("Login Success!")
            Response.Redirect("hosgeldiniz.aspx")



        Else
            MsgBox("Kullanıcı Adı veya Şifreniz Hatalı!!")
        End If

    End Sub
End Class