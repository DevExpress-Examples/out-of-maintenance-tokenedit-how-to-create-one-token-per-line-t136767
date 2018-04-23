Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication86
	Public Class MyRepositoryItemTokenEdit
		Inherits RepositoryItemTokenEdit
		Public Sub New()
		End Sub
		Public Overrides Function CreateViewInfo() As BaseEditViewInfo
			Return New MyTokenEditViewInfo(Me)
		End Function
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return "MyTokenEdit"
			End Get
		End Property
	End Class
End Namespace
