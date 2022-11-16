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
    public partial class Form3 : Form
    {
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//xml/cart.xml";
        public Form3()
        {
            InitializeComponent();
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public static class info
        {
            private static string name;
            private static string address;
            private static string phoneNumber;
            private static string ship;

            public static string GlobalName
            {
                get { return name; }
                set { name = value; }
            }
            public static string GlobalAddress
            {
                get { return address; }
                set { address = value; }
            }
            public static string GlobalPhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
            public static string GlobalShip
            {
                get { return ship; }
                set { ship = value; }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //dgv.Rows.Clear();
            //dgv.ColumnCount = 4;

            //XmlNodeList ds = root.SelectNodes("item");
            //int sd = 0;//lưu chỉ số dòng
            //foreach (XmlNode item in ds)
            //{
            //    int soluong = Convert.ToInt32(item.SelectSingleNode("sl").InnerText);
            //    int gia = Convert.ToInt32(item.SelectSingleNode("price").InnerText);
            //    string tong = Convert.ToString(soluong * gia);
            //    dgv.Rows.Add();
            //    dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("name").InnerText;
            //    dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("sl").InnerText;
            //    dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("price").InnerText;
            //    dgv.Rows[sd].Cells[3].Value = tong;
            //    sd++;
            //}

            int sd = 0;
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            for (int i = 0; i < Form1.ShoppingInfo.GlobalName.Count; i++)
            {
                int qualy = Form1.ShoppingInfo.GlobalQuantity[i];
                int price = Convert.ToInt32(Form1.ShoppingInfo.GlobalPrice[i]);
                float tong = qualy * price;
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = Form1.ShoppingInfo.GlobalName[i];
                dgv.Rows[sd].Cells[1].Value = Form1.ShoppingInfo.GlobalQuantity[i].ToString();
                dgv.Rows[sd].Cells[2].Value = Form1.ShoppingInfo.GlobalPrice[i];
                dgv.Rows[sd].Cells[3].Value = tong.ToString();
                sd++;
            }
        }
        public item i = new item();

        private void skinButton1_Click(object sender, EventArgs e)
        {
            info.GlobalName = txt_name.Text;
            info.GlobalAddress = txt_address.Text;
            info.GlobalPhoneNumber = txt_phone.Text;
            info.GlobalShip = skinRadioButton1.Checked ? skinRadioButton1.Text : skinRadioButton1.Text;
            if (Form1.ShoppingInfo.GlobalName.Count != 0)
            {
                Form4 page = new Form4();
                page.Show();
            }
            else
            {
                MessageBox.Show("Không tồn tại đơn hàng trong giỏ.");
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            int x = Form1.ShoppingInfo.GlobalName.IndexOf(name);
            Form1.ShoppingInfo.GlobalName.RemoveAt(x);
            Form1.ShoppingInfo.GlobalPrice.RemoveAt(x);
            Form1.ShoppingInfo.GlobalQuantity.RemoveAt(x);
            dgv.Rows.RemoveAt(rowIdex);
            MessageBox.Show("Đã xóa " + name + " ra khỏi giỏ hàng.");
        }
    }
}
