using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant {
    public partial class frmReport : Form {
        private SqlConnection con;
        private SqlDataReader dr;
        private SqlCommand cmd;

        public frmReport() {
            InitializeComponent();
        }

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void frmReport_Load(object sender, EventArgs e) {
            chartReport.AxisX.Add(new LiveCharts.Wpf.Axis {
                Title = "Date",
                Labels = new[ ] { "01", "02", "03", "04", "05", "06", "07" }
            });
            chartReport.AxisY.Add(new LiveCharts.Wpf.Axis {
                Title = "Total Amount",
                LabelFormatter = value => value.ToString("C2")
            });
            chartReport.LegendLocation = LiveCharts.LegendLocation.Right;
            chartReport.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<double> values = new List<double>();
            try {
                con = new SqlConnection("Data Source=OUN-CHANRAKSMEY;Initial Catalog=RestuarantDB;user=smey;password=123");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tbReport", con);
                dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    dgvReport.Rows.Add(dr[0], dr[1], dr[2]);
                    values.Add(double.Parse(dr[2].ToString()));
                }
                series.Add(new LineSeries() { Title = "Revenue", Values = new ChartValues<double>(values) });
                chartReport.Series = series;
            } catch (Exception ex) {
                MessageBox.Show("Connection Failed\nError:" + ex.Message);
            }
        }
    }
}
