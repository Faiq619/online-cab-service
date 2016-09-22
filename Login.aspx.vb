Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel2 As System.Web.UI.WebControls.Panel
    Protected WithEvents RadioButtonList1 As System.Web.UI.WebControls.RadioButtonList
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents Button2 As System.Web.UI.WebControls.Button
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Public Shared x As Integer
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If Me.RadioButtonList1.Items.FindByValue("new").Selected = True Then
            Me.Button2.Visible = True
            Me.TextBox1.Visible = False
            Me.TextBox2.Visible = False
            Me.Button1.Visible = False
            Me.Label3.Visible = False
            Me.Label2.Visible = False
        ElseIf Me.RadioButtonList1.Items.FindByValue("already a user").Selected = True Then
            Me.Button2.Visible = False
            Me.TextBox1.Visible = True
            Me.TextBox2.Visible = True
            Me.Button1.Visible = True
            Me.Label3.Visible = True
            Me.Label2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim flag As Integer = 0
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from Clogin", con)
        Dim rs As SqlDataReader = cmd.ExecuteReader
        While rs.Read
            If rs("Username") = TextBox1.Text AndAlso rs("password") = TextBox2.Text Then
                flag = 1
                x = rs("id")
                Exit While
            Else
                flag = 0
            End If
        End While
        If flag = 0 Then
            Label4.Visible = True
            Label4.Text = "incorrect username or password"
        Else
            Response.Redirect("booking.aspx")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("SignUp.aspx")
    End Sub
End Class
