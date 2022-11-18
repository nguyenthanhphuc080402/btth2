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
        //public XmlDocument doc = new XmlDocument();
        //public XmlElement root;
        //private string fileName = @"..//..//xml/feedback.xml";
        private double tongAll = 0;
        public Form3()
        {
            InitializeComponent();
            //doc.Load(fileName);
            //root = doc.DocumentElement;
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

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(137, 212, 238);
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
                tongAll += tong;
            }
            lbl_tong.Text = tongAll.ToString()+"đ";
        }
        public item i = new item();
        public XmlDocument doc = new XmlDocument();
        public XmlElement root;
        private string fileName = @"..//..//xml/history.xml";

        public void Add(string a, string b, string c, string d)
        {
            doc.Load(fileName);
            root = doc.DocumentElement;

            XmlNode item = doc.CreateElement("item");

            XmlElement Name_ = doc.CreateElement("name");
            Name_.InnerText = a;
            item.AppendChild(Name_);

            XmlElement Price_ = doc.CreateElement("price");
            Price_.InnerText = c;
            item.AppendChild(Price_);

            XmlElement Sl_ = doc.CreateElement("quality");
            Sl_.InnerText = b;
            item.AppendChild(Sl_);

            XmlElement Time_ = doc.CreateElement("time");
            Time_.InnerText = d;
            item.AppendChild(Time_);

            root.AppendChild(item);
            doc.Save(fileName);
        }
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
            // add đơn hàng vào file xml lịch sử.
            for(int i= 0; i< Form1.ShoppingInfo.GlobalName.Count; i++)
            {
                Add(Form1.ShoppingInfo.GlobalName[i], Convert.ToString(Form1.ShoppingInfo.GlobalQuantity[i]), Form1.ShoppingInfo.GlobalPrice[i], DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            }

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            int rowIdex = dgv.CurrentCell.RowIndex;
            string name = dgv.Rows[rowIdex].Cells[0].Value.ToString();
            double price = Convert.ToDouble(dgv.Rows[rowIdex].Cells[2].Value.ToString());
            double sl = Convert.ToDouble(dgv.Rows[rowIdex].Cells[1].Value.ToString());
            tongAll = tongAll - price* sl;
            lbl_tong.Text = tongAll.ToString()+"đ";
            int x = Form1.ShoppingInfo.GlobalName.IndexOf(name);
            Form1.ShoppingInfo.GlobalName.RemoveAt(x);
            Form1.ShoppingInfo.GlobalPrice.RemoveAt(x);
            Form1.ShoppingInfo.GlobalQuantity.RemoveAt(x);
            dgv.Rows.RemoveAt(rowIdex);
            //MessageBox.Show("Đã xóa " + name + " ra khỏi giỏ hàng.");
        }
    }
}
