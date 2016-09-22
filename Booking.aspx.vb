Imports System.Data.SqlClient
Imports System.Data
Public Class Booking
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Protected WithEvents DropDownList1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DropDownList2 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox1 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Protected WithEvents Calendar1 As System.Web.UI.WebControls.Calendar
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents TextBox2 As System.Web.UI.WebControls.TextBox
    Protected WithEvents Button1 As System.Web.UI.WebControls.Button
    Protected WithEvents TextBox3 As System.Web.UI.WebControls.TextBox

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
        TextBox1.Enabled = False
        Dim con As SqlConnection = New SqlConnection("server=vb;Database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from cities", con)
        Dim rs As SqlDataReader = cmd.ExecuteReader
        While rs.Read
            DropDownList1.Items.Add(rs("city"))
            DropDownList2.Items.Add(rs("city"))
        End While
        con.Close()
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Calendar1.Visible = True
    End Sub

    Private Sub Calendar1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString()
        Calendar1.Visible = False
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from Fair", con) ' where Origin='" & DropDownList1.SelectedValue & "' & Destination='" & DropDownList2.SelectedValue & "'", con)
        Dim rs As SqlDataReader = cmd.ExecuteReader
        While rs.Read()
            If rs("Origin") = DropDownList1.SelectedValue AndAlso rs("Destination") = DropDownList2.SelectedValue Then
                Me.TextBox2.Text = rs("CFair")
            End If
        End While
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Login
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("insert into Booking values(" & obj.x & ",'" & DropDownList1.SelectedValue & "','" & DropDownList2.SelectedValue & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "',0)", con)
        cmd.ExecuteNonQuery()
        con.Close()
        Response.Redirect("confirm.aspx")
    End Sub
End Class
