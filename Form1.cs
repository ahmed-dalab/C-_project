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

namespace C__project
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server = .; database = studentsdb; integrated security = true");

        private void stdName_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            try {
                conn.Open();
                string query = $"INSERT INTO students VALUES ('{txtName.Text}', '{txtPhone.Text}', {txtAge.Text})";

                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Student created successfully");
               
                conn.Close();
                displayData();
            } catch(Exception exeception) {
                MessageBox.Show(exeception.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayData();
        }
        void displayData()
        {
            try
            {
                conn.Open();
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT  *  FROM students", conn);
                adapter.Fill(dataset, "students");
                dataGridView.DataSource = dataset.Tables["students"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int index = 0;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAge.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
