Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication86
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.tokenEdit1 = New MyTokenEdit()
			CType(Me.tokenEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tokenEdit1
			' 
			Me.tokenEdit1.Location = New System.Drawing.Point(12, 24)
			Me.tokenEdit1.Name = "tokenEdit1"
			Me.tokenEdit1.Properties.Separators.AddRange(New String() { ","})
			Me.tokenEdit1.Properties.Tokens.AddRange(New DevExpress.XtraEditors.TokenEditToken() { New DevExpress.XtraEditors.TokenEditToken("One", "One"), New DevExpress.XtraEditors.TokenEditToken("Two", "Two"), New DevExpress.XtraEditors.TokenEditToken("Three", "Three")})
			Me.tokenEdit1.Size = New System.Drawing.Size(283, 20)
			Me.tokenEdit1.TabIndex = 0
			Me.tokenEdit1.UseOptimizedRendering = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(310, 231)
			Me.Controls.Add(Me.tokenEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.tokenEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tokenEdit1 As MyTokenEdit
	End Class
End Namespace

