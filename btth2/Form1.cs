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
    public partial class Form1 : Form
    {
        public string tag = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void loadCategory(string XMLTag)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"..//..//data.xml");
            XmlNodeList nodeList;
            try
            {
                nodeList = xdoc.DocumentElement.SelectNodes("/shop/" + XMLTag + "/item");
                List<string> listName = new List<string>();
                foreach(XmlNode node in nodeList)
                {
                    listName.Add(node.SelectSingleNode("name").InnerText);
                }
                lab1.Text = listName[0];
                lab2.Text = listName[1];
                lab3.Text = listName[2];
                lab4.Text = listName[3];
                lab5.Text = listName[4];
                lab6.Text = listName[5];

                List<string> listPath = new List<string>();
                foreach (XmlNode node in nodeList)
                {
                    listPath.Add(node.SelectSingleNode("path").InnerText);
                }
                btn_img1.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[0] + ".jpg");
                btn_img2.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[1] + ".jpg");
                btn_img3.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[2] + ".jpg");
                btn_img4.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[3] + ".jpg");
                btn_img5.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[4] + ".jpg");
                btn_img6.BackgroundImage = Image.FromFile(@"..//..//img/" + XMLTag +"/"+ listPath[5] + ".jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCategory("caphe");
            tag = "caphe";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            loadCategory("caphe");
            tag = "caphe";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            loadCategory("traicay");
            tag = "traicay";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            loadCategory("snack");
            tag = "snack";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            loadCategory("tea");
            tag = "tea";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            loadCategory("tainha");
            tag = "tainha";
        }

        private void btn_img1_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(1, tag);
            page.Show();
        }
        private void btn_img2_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(2, tag);
            page.Show();
        }

        private void btn_img3_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(3, tag);
            page.Show();
        }
        private void btn_img4_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(4, tag);
            page.Show();
        }

        private void btn_img5_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(5, tag);
            page.Show();
        }

        private void btn_img6_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2(6, tag);
            page.Show();
        }
    }
}
