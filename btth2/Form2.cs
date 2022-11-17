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
using System.Xml.Linq;

namespace btth2
{
    public partial class Form2 : Form
    {
        public int stt;
        public string tag;
        public int sl = 1;
        public string name = "";
        public string path = "";
        public string price = "";
        public string discription = "";

        public item i = new item();
        public orders o = new orders();

        //DataTable dt = new DataTable(@"..//..//ds.xsd");
        public Form2(int stt_, string tag_)
        {
            this.stt = stt_;
            this.tag = tag_;
            InitializeComponent();
        }

        public void loadCategory(string XMLTag, int stt)
        {
            var xmlDoc = XDocument.Load(@"..//..//xml/data.xml");
            var data_pre = xmlDoc.Descendants(XMLTag);
            var data = data_pre.Descendants("item").Where(it => (int)it.Element("path") == stt);
            foreach (var item in data)
            {
                name = (string)item.Element("name");
                path = (string)item.Element("path");
                price = (string)item.Element("price");
                discription = (string)item.Element("discription");
                lab_price.Text = price;
                //lab_price.Text = string.Format("{0:0.00}", price.TrimStart(new char[] { '0' }));
                pic_1.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag + "/" + path + ".jpg");
                lab_discription.Text = discription;
                lab_name.Text = name;
                this.Text = name;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_count.Text = Convert.ToString(Form1.ShoppingInfo.GlobalName.Count);
            loadCategory(tag, stt);
            if (tag == "caphe")
            {
                this.BackgroundImage = Image.FromFile(@"..//..//img/background/3.png");
            }else if( tag == "traicay")
            {
                this.BackgroundImage = Image.FromFile(@"..//..//img/background/6.png");

            }
            else if (tag == "tea")
            {
                this.BackgroundImage = Image.FromFile(@"..//..//img/background/11.png");

            }
            else if (tag == "tainha")
            {
                this.BackgroundImage = Image.FromFile(@"..//..//img/background/9.png");

            }
            else
            {
                this.BackgroundImage = Image.FromFile(@"..//..//img/background/10.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sl++;
            lab_sl.Text = sl.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sl == 1) return;
            sl--;
            lab_sl.Text = sl.ToString();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            //Thêm vào giỏ
            //o.name = name;
            //o.price = price;
            //o.Sl = sl.ToString();
            //i.Them(o);
            if (Form1.ShoppingInfo.GlobalName.Contains(name) == false)
            {
                Form1.ShoppingInfo.GlobalName.Add(name);
                Form1.ShoppingInfo.GlobalPrice.Add(price);
                Form1.ShoppingInfo.GlobalQuantity.Add(sl);
            }
            else
            {
                int index = Form1.ShoppingInfo.GlobalName.IndexOf(name);
                Form1.ShoppingInfo.GlobalQuantity[index] += sl;
            }
            lbl_count.Text = Convert.ToString(Form1.ShoppingInfo.GlobalName.Count);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Form3 page = new Form3();
            page.Show();
        }
    }
}
