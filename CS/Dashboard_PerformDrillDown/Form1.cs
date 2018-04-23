using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Collections;
using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.ViewerData;

namespace Dashboard_PerformDrillDown {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            // Loads a dashboard from an XML file.
            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
            // Obtains values that can be used to perform drill-down.
            var drillDownValues = dashboardViewer1.GetAvailableDrillDownValues("gridDashboardItem1");
            foreach (AxisPointTuple rows in drillDownValues) {
                comboBox1.Items.Add(rows.GetAxisPoint().Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            System.Windows.Forms.ComboBox comboBox1 = (System.Windows.Forms.ComboBox) sender;
            if (dashboardViewer1.CanPerformDrillDown("gridDashboardItem1") == true) {
                // Performs drill-down for a selected category.
                dashboardViewer1.PerformDrillDown("gridDashboardItem1", comboBox1.SelectedItem);
            }
            else {
                // Returns to the previous detail level and  
                // performs drill-down for the selected category.
                dashboardViewer1.PerformDrillUp("gridDashboardItem1");
                dashboardViewer1.PerformDrillDown("gridDashboardItem1", comboBox1.SelectedItem);
            }
        }

        private void btnDrillUp_Click(object sender, EventArgs e) {
            if (dashboardViewer1.CanPerformDrillUp("gridDashboardItem1") == true) {
                // Performs a drill-up in the grid dashboard item.
                dashboardViewer1.PerformDrillUp("gridDashboardItem1");
            }
            else XtraMessageBox.Show("Drill-up is not possible at the current detail level");
        }
    }
}