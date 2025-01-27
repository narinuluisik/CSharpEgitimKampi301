using CSharpEgitimKampi501.Dtos;
using Dapper;
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

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("Server=NARIN\\SQLEXPRESS; initial Catalog=EgitimKampi501Db;integrated security=true");


        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values= await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource= values;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
