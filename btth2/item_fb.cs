using btth2.Properties;
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
    public partial class item_fb : UserControl
    {
        int index = 0;
        public item_fb(int i)
        {
            InitializeComponent();
            index = i;
        }

        public Image ItemImage
        {
            get
            {
                return ptr_Item.Image;
            }
            set
            {
                ptr_Item.BackgroundImage = value;
            }
        }

        public string ItemName
        {
            get
            {
                return lbl_Name.Text;
            }
            set
            {
                lbl_Name.Text = value;
            }
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            lbl_core.Text = "1";
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            lbl_core.Text = "2";
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            //change yellow stars to white
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            lbl_core.Text = "3";
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            //change yellow star to white
            pb_str5.Image = Resources.white_star;

            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            lbl_core.Text = "4";
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.yellow_star;
            lbl_core.Text = "5";
        }
        //public item i = new item();
        //public orders o = new orders();
        private void skinButton1_Click(object sender, EventArgs e)
        {
            item i = new item();
            orders o = new orders();
            //Form1.ShoppingInfo.GlobalStar[index] = Convert.ToInt32(lbl_core.Text);
            //Form1.ShoppingInfo.GlobalFeedback[index] = richTextBox1.Text;
            o.Name = this.ItemName;
            o.Feedback = richTextBox1.Text;
            o.Star = lbl_core.Text;
            i.Them(o);
            MessageBox.Show("Đã gửi nhận xét. Thanks \t٩(๑❛ᴗ❛๑)۶");
            skinButton1.Enabled = false;
    }
    }
}
