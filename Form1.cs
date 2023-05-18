using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimirovau
{
    public partial class Authorization_frm : Form
    {
        
        DataTable table;
        public Authorization_frm()
        {
            InitializeComponent();
        }
        private void Grid()
        {
            SqlConnection connect = new SqlConnection(@"Data Sourse=DESKTOP-9K9G2JH\SQLEXPRESS;Initial Catalog=SecurityDb_Ultimirovau;Integrated Security=True");
            connect.Open();
            SqlDataAdapter adtpr = new SqlDataAdapter();
            new SqlDataAdapter("selest * from UserTable",connect);
            table = new DataTable();
            adtpr.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();   

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try 
            {
                if (Log_Txt.Text == "" || Pass_Txt.Text == ""||textBox1.Text=="")
                {
                    MessageBox.Show("Заполните пустые поля");
                }
                else
                {

                }
                if (Pass_Txt==textBox1)
                {
                   
                }
            }
            catch
            {

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
