Imports System.Data.SqlClient
Public Class Confirm
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox6 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox5 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox4 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Public Shared amt As Integer
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As New Login
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from Customer", con) '& "select * from Booking", con) '("select Name, Contact, origin, Destination, Address, Amount from customer,Booking where customer.id=" & obj.x & " or Booking.id=" & obj.x & "", con)
        Dim rs As SqlDataReader
        rs = cmd.ExecuteReader
        While rs.Read()
            If rs("id") = obj.x Then
                Me.TextBox1.Text = rs("Name")
                Me.TextBox2.Text = rs("Contact")
            End If
        End While
        con.Close()
        con.Open()
        cmd.CommandText = "select * from Booking"
        rs = cmd.ExecuteReader
        While rs.Read()
            If rs("id") = obj.x Then
                Me.TextBox3.Text = rs("Origin")
                Me.TextBox4.Text = rs("Destination")
                Me.TextBox5.Text = rs("Address")
                Me.TextBox6.Text = rs("Amount")
            End If
        End While
        amt = TextBox6.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("Payment.aspx")
    End Sub
End Class
