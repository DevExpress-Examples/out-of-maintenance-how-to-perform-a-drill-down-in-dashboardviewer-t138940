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
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(242)))), (CInt((CByte(242)))), (CInt((CByte(242)))))
			Me.dashboardViewer1.Appearance.Options.UseBackColor = True
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 35)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(827, 400)
			Me.dashboardViewer1.TabIndex = 0
			' 
			' btnDrillUp
			' 
			Me.btnDrillUp.Location = New System.Drawing.Point(218, 5)
			Me.btnDrillUp.Name = "btnDrillUp"
			Me.btnDrillUp.Size = New System.Drawing.Size(110, 23)
			Me.btnDrillUp.TabIndex = 1
			Me.btnDrillUp.Text = "Drill Up"
			Me.btnDrillUp.UseVisualStyleBackColor = True
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(12, 5)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(180, 21)
			Me.comboBox1.TabIndex = 2
			Me.comboBox1.Text = "(Select a category to drill-down)"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.comboBox1)
			Me.panelControl1.Controls.Add(Me.btnDrillUp)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(827, 35)
			Me.panelControl1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(827, 435)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private btnDrillUp As System.Windows.Forms.Button
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

