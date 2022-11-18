using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace btth2
{
    public partial class Form7 : Form
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//xml/history.xml";
        public Form7()
        {
            InitializeComponent();
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        void StyleDatagridview()
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 63, 5);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //dgv.EnableHeadersVisualStyles = false;
            //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(137, 212, 238);
            StyleDatagridview();
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            XmlNodeList ds = root.SelectNodes("item");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("quality").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("price").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("time").InnerText;
                sd++;
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
