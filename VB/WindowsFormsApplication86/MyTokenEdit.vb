Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports System.Drawing

Namespace WindowsFormsApplication86
    Public Class MyTokenEdit
        Inherits TokenEdit
        Shared Sub New()
            Register()
        End Sub
        Public Shared Sub Register()
            Dim _image As Image = Nothing

            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("MyTokenEdit", _
                                                                           GetType(MyTokenEdit), _
                                                                           GetType(MyRepositoryItemTokenEdit), _
                                                                           GetType(MyTokenEditViewInfo), _
                                                                               New TokenEditPainter(), _
                                                                               True, _
                                                                               _image))
        End Sub
        Public Sub New()
        End Sub
        Public Shadows Sub SetCaretToEnd()
            BeginUpdate()
            Try
                MyBase.SetCaretToEnd()
            Finally
                EndUpdate()
            End Try
        End Sub
        Protected Overrides Sub UpdateEditValueOnClosePopupCore(ByVal token As TokenEditToken)
            MyBase.UpdateEditValueOnClosePopupCore(token)
            SetCaretToEnd()
        End Sub
        Protected Overrides Function ShouldFilterSeparators() As Boolean
            Return False
        End Function
        Protected Overrides Function CreatePopupController() As BaseTokenEditPopupController
            Return New MyTokenEditTokenListPopupController(Me)
        End Function
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return "MyTokenEdit"
            End Get
        End Property
    End Class


End Namespace
