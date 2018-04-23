Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication86
	Public Class MyTokenEditTokenListPopupController
		Inherits TokenEditTokenListPopupController
		Public Sub New(ByVal tokenEdit As TokenEdit)
			MyBase.New(tokenEdit)
		End Sub
		Protected Overrides Sub ShowPopupIfNeeded()
			'if((ControlUtils.IsKeyPressed(Keys.Back))
			If (NativeMethods.GetAsyncKeyState(CInt(Fix(Keys.Back))) And &H8000) <> 0 Then
				Return
			End If
			MyBase.ShowPopupIfNeeded()
		End Sub
	End Class
End Namespace
