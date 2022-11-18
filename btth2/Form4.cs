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

            for (int i = 0; i < Form1.ShoppingInfo.GlobalName.Count; i++)
            {
                string name = Form1.ShoppingInfo.GlobalName[i];
                int qualy = Form1.ShoppingInfo.GlobalQuantity[i];
                int price = Convert.ToInt32(Form1.ShoppingInfo.GlobalPrice[i]);
                string tong = Convert.ToString(qualy * price);
                dt.Rows.Add(Convert.ToString(i+1), name, Convert.ToString(qualy), Convert.ToString(price), tong);
            }


            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "..//..//Report2.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "name";
            para1.Values.Add(Form3.info.GlobalName);

            ReportParameter para2 = new ReportParameter();
            para2.Name = "address";
            para2.Values.Add(Form3.info.GlobalAddress);

            ReportParameter para3 = new ReportParameter();
            para3.Name = "phonenumber";
            para3.Values.Add(Form3.info.GlobalPhoneNumber);

            ReportParameter para4 = new ReportParameter();
            para4.Name = "ship";
            para4.Values.Add(Form3.info.GlobalShip);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4});
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadReportTest();
            this.reportViewer1.RefreshReport();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 page = new Form5();
            page.Show();
        }
    }
}
