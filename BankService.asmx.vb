Imports System.Web.Services
Imports System.Data.SqlClient
<System.Web.Services.WebService(Namespace := "http://tempuri.org/OnlineCabService/BankService")> _
Public Class BankService
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    ' WEB SERVICE EXAMPLE
    ' The HelloWorld() example service returns the string Hello World.
    ' To build, uncomment the following lines then save and build the project.
    ' To test this web service, ensure that the .asmx file is the start page
    ' and press F5.
    '
    '<WebMethod()> _
    Public Function Transaction(ByVal x As String, ByVal y As String, ByVal z As String, ByVal p As Date) As String
        Dim flag As Integer
        Dim b As Integer
        Dim con As SqlConnection = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
        Dim obj As New Login
        Dim cmd As SqlCommand = New SqlCommand("select * from CAccount where id=" & obj.x & "", con)
        'cmd.Parameters.Add("@id", obj.x)
        Dim rs As SqlDataReader = cmd.ExecuteReader
        rs.Read()
        If rs("CC_No") = y AndAlso rs("CVV_No") = z Then 'AndAlso rs("Expiry_Date") = p Then
            If rs("bal") < x Then 'Or rs("Expiry_Date") < DateTime.Now.ToShortDateString Then
                Return "Insufficient balance or card expired"
            Else
                b = rs("bal")
                flag = 1
            End If
        End If
        con.Close()
        If flag = 0 Then
            Return "Transaction unsuccessful"
        Else
            Dim s As Integer = CInt(x)
            con.Open()
            cmd.CommandText = "update CAccount set Bal=" & b - s & " where id=" & obj.x & ""
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update SAccount set Bal=" & b + s & ""
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update Booking set Flag=1 where id=" & obj.x & ""
            cmd.ExecuteNonQuery()
            Return "   "
        End If
    End Function
End Class
