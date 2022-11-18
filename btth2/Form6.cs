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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.ShoppingInfo.GlobalName.Count; i++)
            {
                item_fb x = new item_fb();
                x.ItemImage = Image.FromFile(Form1.ShoppingInfo.GlobalPath[i]);
                x.ItemName = Form1.ShoppingInfo.GlobalName[i];
                flowLayoutPanel1.Controls.Add(x);
            }
        }
    }
}
