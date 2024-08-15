using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216316_PhanNgocBaoVinh_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data()
        {
            String[] foods = { "Grain", "Beard", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            foreach (String item in foods)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                checkBox.BackColor = System.Drawing.SystemColors.ControlLight;
                checkBox.ForeColor = System.Drawing.SystemColors.ControlDark;
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string food_clicked = "";
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    CheckBox temp = (CheckBox)item;
                    if (temp.Checked)
                    {
                        food_clicked = food_clicked + " " + temp.Text;

                    }
                }
            }
            MessageBox.Show("Food clicked: " + food_clicked);
        }
    }
}
