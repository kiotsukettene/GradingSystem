﻿Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class RoundCornerTextbox
	Inherits TextBox
	<DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.Winapi)>
	Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer,
										   ByVal nBottomRect As Integer, ByVal nHeightRect As Integer, ByVal nWidthRect As Integer) As IntPtr
	End Function
	Protected Overrides Sub OnCreateControl()
		MyBase.OnCreateControl()
		Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
	End Sub

	Protected Overrides Sub OnResize(e As EventArgs)
		MyBase.OnResize(e)
		Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
	End Sub
End Class
