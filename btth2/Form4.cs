using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btth2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void LoadReportTest()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(string));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("TT", typeof(string));

            dt.Rows.Add("1", "Nước tẩy rửa đa năng", "1", "123.000", "123.000");
            dt.Rows.Add("2", "Nước suối lavie chai 1 lít", "1", "123.000", "123.000");
            dt.Rows.Add("3", "Nước tăng lực String", "1", "123.000", "123.000");
            dt.Rows.Add("4", "Dầu ăn Simply chai 5 lít", "1", "123.000", "123.000");
            dt.Rows.Add("5", "Bánh gạo One One", "1", "123.000", "123.000");

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenKH"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add("Nguyễn Văn An");
            //ReportParameter para2 = new ReportParameter();
            //para2.Name = "TenKH";
            //para2.Values.Add(TenKH);
            //ReportParameter para3 = new ReportParameter();
            //para3.Name = "SoHD";
            //para3.Values.Add(SoHD);
            //ReportParameter para4 = new ReportParameter();
            //para4.Name = "NgayIn";
            //para4.Values.Add(NgayIn);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1/*, para2, para3, para4*/ });
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadReportTest();
            this.reportViewer1.RefreshReport();
        }
    }
}
