using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string conString = @"Data source = DESKTOP-SK4SD62\MEOW; Initial catalog = Meow; integrated security=true";
            SqlConnection myCon = new SqlConnection(conString);
            SqlDataReader reader1;
            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                string ComDel = "select login from Users where role = 'admin'";
                SqlCommand cmd1 = new SqlCommand(ComDel, myCon);
                myCon.Open();
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    listBox1.Items.Add(reader1[0].ToString());
                }
                myCon.Close();
            }
            if (comboBox1.SelectedIndex.ToString() == "1")
            {
                string ComDel = "select login from Users where role = 'user'";
                SqlCommand cmd1 = new SqlCommand(ComDel, myCon);
                myCon.Open();
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    listBox1.Items.Add(reader1[0].ToString());
                }
                myCon.Close();
            }
            if (comboBox1.SelectedIndex.ToString() == "2")
            {
                string ComDel = "select login from Users";
                SqlCommand cmd1 = new SqlCommand(ComDel, myCon);
                myCon.Open();
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    listBox1.Items.Add(reader1[0].ToString());
                }
                myCon.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
