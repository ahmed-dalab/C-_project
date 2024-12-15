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

        private void stdName_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            try {
                SqlConnection conn = new SqlConnection("server = .; database = studentsdb; integrated security = true");
                conn.Open();
                string query = $"INSERT INTO students VALUES ('{txtName.Text}', '{txtPhone.Text}', {txtAge.Text})";

                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Student created successfully");

                conn.Close();
            } catch(Exception exeception) {
                MessageBox.Show(exeception.Message);
            }

        }
    }
}
