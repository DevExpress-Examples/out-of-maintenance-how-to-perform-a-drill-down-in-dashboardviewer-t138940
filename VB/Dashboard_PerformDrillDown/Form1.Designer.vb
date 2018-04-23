Imports Microsoft.VisualBasic
Imports System
Namespace Dashboard_PerformDrillDown
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
			Me.components = New System.ComponentModel.Container()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.btnDrillUp = New System.Windows.Forms.Button()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
			Me.dashboardViewer1.Size = New System.Drawing.Size(817, 433)
			Me.dashboardViewer1.TabIndex = 0
			' 
			' btnDrillUp
			' 
			Me.btnDrillUp.Location = New System.Drawing.Point(139, 13)
			Me.btnDrillUp.Name = "btnDrillUp"
			Me.btnDrillUp.Size = New System.Drawing.Size(110, 23)
			Me.btnDrillUp.TabIndex = 1
			Me.btnDrillUp.Text = "PerformDrillUp"
			Me.btnDrillUp.UseVisualStyleBackColor = True
'			Me.btnDrillUp.Click += New System.EventHandler(Me.btnDrillUp_Click);
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(12, 14)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 2
			Me.comboBox1.Text = "(Select a category)"
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(817, 433)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.btnDrillUp)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Name = "Form1"
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private WithEvents btnDrillUp As System.Windows.Forms.Button
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace

