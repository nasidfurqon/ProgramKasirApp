using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace ProgramKasirApp
{
    public partial class Form3 : Form
    {
        public DataTable DatabaseConector()
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=programkasir;Uid=root;Pwd=khoirul;sslmode=none;pooling=false"))
            {
                using (var command = new MySqlCommand("SELECT * FROM kasir", connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    data.Load(reader);
                }
            }
            return data;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource=DatabaseConector();
        }
    }
}