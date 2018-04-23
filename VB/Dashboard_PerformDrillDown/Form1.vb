Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports System.Collections
Imports DevExpress.DashboardCommon

Namespace Dashboard_PerformDrillDown
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()

			' Loads a dashboard from an XML file.
			dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")
			' Obtains values that can be used to perform drill-down.
            Dim drillDownValues As DashboardDataSet =
                dashboardViewer1.GetAvailableSelections("gridDashboardItem1")
			For Each rows As DashboardDataRow In drillDownValues
				comboBox1.Items.Add(rows(0))
			Next rows
		End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
            Handles comboBox1.SelectedIndexChanged
            Dim comboBox1 As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
            If dashboardViewer1.CanPerformDrillDown("gridDashboardItem1") = True Then
                ' Performs drill-down for a selected category.
                dashboardViewer1.PerformDrillDown("gridDashboardItem1", comboBox1.SelectedItem)
            Else
                ' Returns to the previous detail level and  
                ' performs drill-down for the selected category.
                dashboardViewer1.PerformDrillUp("gridDashboardItem1")
                dashboardViewer1.PerformDrillDown("gridDashboardItem1", comboBox1.SelectedItem)
            End If
        End Sub

        Private Sub btnDrillUp_Click(ByVal sender As Object, ByVal e As EventArgs) _
            Handles btnDrillUp.Click
            If dashboardViewer1.CanPerformDrillUp("gridDashboardItem1") = True Then
                ' Performs a drill-up in the grid dashboard item.
                dashboardViewer1.PerformDrillUp("gridDashboardItem1")
            Else
                XtraMessageBox.Show("Drill-up is not possible at the current detail level")
            End If
        End Sub
	End Class
End Namespace