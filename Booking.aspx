<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Booking.aspx.vb" Inherits="OnlineCabService.Booking"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Booking</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffc0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="#8080FF" Width="1008px" Height="54px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:Label id="Label1" runat="server" Width="520px" Font-Size="XX-Large" Font-Bold="True" Font-Names="Sylfaen">FAIQ CAB SERVICES</asp:Label>&nbsp;&nbsp;&nbsp; 
</asp:panel><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 248px; POSITION: absolute; TOP: 128px" runat="server">From</asp:label><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 103; LEFT: 384px; POSITION: absolute; TOP: 128px"
				runat="server" Width="160px"></asp:dropdownlist><asp:label id="Label3" style="Z-INDEX: 104; LEFT: 248px; POSITION: absolute; TOP: 176px" runat="server">To</asp:label><asp:dropdownlist id="DropDownList2" style="Z-INDEX: 105; LEFT: 384px; POSITION: absolute; TOP: 176px"
				runat="server" Width="160px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 248px; POSITION: absolute; TOP: 224px" runat="server">Date</asp:label><asp:textbox id="TextBox1" style="Z-INDEX: 107; LEFT: 384px; POSITION: absolute; TOP: 224px"
				runat="server" Width="160px" Height="27px"></asp:textbox><asp:imagebutton id="ImageButton1" style="Z-INDEX: 108; LEFT: 544px; POSITION: absolute; TOP: 224px"
				runat="server" Height="26px" ImageUrl="file:///C:\Documents and Settings\VB Students\Desktop\Project images\calendar-20.png"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 109; LEFT: 568px; POSITION: absolute; TOP: 224px"
				runat="server" BackColor="#FFFFCC" Width="152px" Height="96px" Font-Size="8pt" Font-Names="Verdana" ShowGridLines="True" BorderColor="#FFCC66" ForeColor="#663399" DayNameFormat="FirstLetter" BorderWidth="1px" Visible="False">
				<TodayDayStyle ForeColor="White" BackColor="#FFCC66"></TodayDayStyle>
				<SelectorStyle BackColor="#FFCC66"></SelectorStyle>
				<NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC"></NextPrevStyle>
				<DayHeaderStyle Height="1px" BackColor="#FFCC66"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" BackColor="#CCCCFF"></SelectedDayStyle>
				<TitleStyle Font-Size="9pt" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label5" style="Z-INDEX: 110; LEFT: 248px; POSITION: absolute; TOP: 280px" runat="server">Pick up Address</asp:label><asp:label id="Label6" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 360px" runat="server">Payable Amount</asp:label><asp:textbox id="TextBox2" style="Z-INDEX: 112; LEFT: 384px; POSITION: absolute; TOP: 360px"
				runat="server" Width="160px" Enabled="False"></asp:textbox><asp:button id="Button1" style="Z-INDEX: 113; LEFT: 472px; POSITION: absolute; TOP: 432px" runat="server"
				Width="74px" Text="Continue"></asp:button><asp:textbox id="TextBox3" style="Z-INDEX: 114; LEFT: 384px; POSITION: absolute; TOP: 280px"
				runat="server" Width="160px" TextMode="MultiLine"></asp:textbox></form>
	</body>
</HTML>
