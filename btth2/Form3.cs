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

namespace btth2
{
    public partial class Form3 : Form
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//cart.xml";
        public Form3()
        {
            InitializeComponent();
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            XmlNodeList ds = root.SelectNodes("item");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                int soluong = Convert.ToInt32(item.SelectSingleNode("sl").InnerText);
                int gia = Convert.ToInt32(item.SelectSingleNode("price").InnerText);
                string tong = Convert.ToString(soluong * gia);
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("sl").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("price").InnerText;
                dgv.Rows[sd].Cells[3].Value = tong;
                sd++;
            }
        }
        public item i = new item();

        private void skinButton1_Click(object sender, EventArgs e)
        {
            i.xoaAll();
        }
    }
}
