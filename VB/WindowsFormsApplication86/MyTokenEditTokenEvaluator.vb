Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication86
	Public Class MyTokenEditTokenEvaluator
		Inherits TokenEditTokenEvaluator
		Public Sub New(ByVal viewInfo As TokenEditViewInfo)
			MyBase.New(viewInfo)
		End Sub
		Public Overrides Function GetEditorText() As String
			If EditInfo Is Nothing OrElse EditInfo.ItemCount = 0 Then
				Return String.Empty
			End If
			Dim sb As New StringBuilder()
			For Each tokenInfo As TokenEditTokenInfo In EditInfo.Items
				If tokenInfo.ItemType <> TokenEditItemType.Link Then
					Continue For
				End If
				sb.Append(tokenInfo.GetToken())
				sb.Append(Environment.NewLine)
			Next tokenInfo
			Return sb.ToString()
		End Function
	End Class
End Namespace
