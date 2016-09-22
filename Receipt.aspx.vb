Imports System.Data.SqlClient
Public Class Receipt
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Login
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select name,contact,email from Customer where id=" & obj.x & "", con) ' or Bookning.id=" & obj.x & "", con)
        Dim rs As SqlDataReader = cmd.ExecuteReader
        rs.Read()
        Label3.Text = rs("Name")
        Label4.Text = rs("Contact")
        Label5.Text = rs("Email")
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Booking where id=" & obj.x & ""
        rs = cmd.ExecuteReader
        rs.Read()
        Label6.Text = rs("origin")
        Label7.Text = rs("Destination")
        Label8.Text = rs("Dated")
        Label9.Text = rs("Address")
        Label10.Text = rs("Amount")
    End Sub

End Class
