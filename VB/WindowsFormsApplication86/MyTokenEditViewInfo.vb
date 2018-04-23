Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication86
	Public Class MyTokenEditViewInfo
		Inherits TokenEditViewInfo
		Public Sub New(ByVal properties As MyRepositoryItemTokenEdit)
			MyBase.New(properties)
		End Sub
		Protected Overrides Function CreateTokenEvaluator() As TokenEditTokenEvaluator
			Return New MyTokenEditTokenEvaluator(Me)
		End Function
	End Class
End Namespace
