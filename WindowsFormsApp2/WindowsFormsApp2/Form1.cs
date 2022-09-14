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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "meowDataSet.Bibl". При необходимости она может быть перемещена или удалена.
            this.biblTableAdapter.Fill(this.meowDataSet.Bibl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source = DESKTOP-SK4SD62\MEOW; Initial Catalog = meow; Integrated Security = true";
            SqlConnection MyConnection = new SqlConnection(ConString);
            string DeString = "Delete from Bibl where id = @id";
            SqlParameter p1 = new SqlParameter("@id", textBox1.Text);
            SqlCommand delCmd = new SqlCommand(DeString, MyConnection);
            delCmd.Parameters.Add(p1);
            MyConnection.Open();
            delCmd.ExecuteNonQuery();
            MyConnection.Close();

            this.biblTableAdapter.Fill(this.meowDataSet.Bibl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source = DESKTOP-SK4SD62\MEOW; Initial Catalog = meow; Integrated Security = true";
            SqlConnection MyConnection = new SqlConnection(ConString);
            string UpdString = "Update Bibl set [Название]=@name, [Автор]=@auth, [количество страниц]=@count, [год]=@year where id = @id";
            SqlParameter p1 = new SqlParameter("@id", textBox6.Text);
            SqlParameter p2 = new SqlParameter("@name", textBox5.Text);
            SqlParameter p3 = new SqlParameter("@auth", textBox4.Text);
            SqlParameter p4 = new SqlParameter("@count", textBox2.Text);
            SqlParameter p5 = new SqlParameter("@year", textBox3.Text);
            SqlCommand updCmd = new SqlCommand(UpdString, MyConnection);
            updCmd.Parameters.Add(p1);
            updCmd.Parameters.Add(p2);
            updCmd.Parameters.Add(p3);
            updCmd.Parameters.Add(p4);
            updCmd.Parameters.Add(p5);
            MyConnection.Open();
            updCmd.ExecuteNonQuery();
            MyConnection.Close();

            this.biblTableAdapter.Fill(this.meowDataSet.Bibl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source = DESKTOP-SK4SD62\MEOW; Initial Catalog = meow; Integrated Security = true";
            SqlConnection MyConnection = new SqlConnection(ConString);
            string InsString = "insert into Bibl values (@name, @auth, @count, @year)";
            SqlParameter p1 = new SqlParameter("@name", textBox10.Text);
            SqlParameter p2 = new SqlParameter("@auth", textBox8.Text);
            SqlParameter p3 = new SqlParameter("@count", textBox7.Text);
            SqlParameter p4 = new SqlParameter("@year", textBox9.Text);
            SqlCommand insCmd = new SqlCommand(InsString, MyConnection);
            insCmd.Parameters.Add(p1);
            insCmd.Parameters.Add(p2);
            insCmd.Parameters.Add(p3);
            insCmd.Parameters.Add(p4);
            MyConnection.Open();
            insCmd.ExecuteNonQuery();
            MyConnection.Close();

            this.biblTableAdapter.Fill(this.meowDataSet.Bibl);
        }
    }
}
