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
        int stt;
        string tag;
        public Form2(int stt_, string tag_)
        {
            this.stt = stt_;
            this.tag = tag_;
            InitializeComponent();
        }

        public void loadCategory(string XMLTag, int stt)
        {
            //XmlDocument xdoc = new XmlDocument();
            //xdoc.Load(@"..//..//data.xml");
            //XmlNodeList nodeList;
            //try
            //{
            //    nodeList = xdoc.DocumentElement.SelectNodes("/shop/" + XMLTag + "/item");
            //    List<string> listName = new List<string>();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            var xmlDoc = XDocument.Load(@"..//..//data.xml");
            var data_pre = xmlDoc.Descendants(XMLTag);
            var data = data_pre.Descendants("item").Where(it => (int)it.Element("path") == stt);
            
            foreach(var item in data)
            {
                lab_name.Text = item.Value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadCategory(tag, stt);
        }
    }
}
