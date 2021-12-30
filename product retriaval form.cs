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

namespace Burhani_Management_System
{
    public partial class product_retrieval_form : Form
    {
        SqlConnection con;
      
        public product_retrieval_form()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Burhani Management System";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'Products'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                search_column_combo.Items.Add(rd["COLUMN_NAME"]);
            }
            rd.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void product_retrieval_form_Load(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_column_combo.SelectedIndex > - 1)
            {
                SqlCommand c = new SqlCommand();
                c.Connection = con;
                string column = search_column_combo.SelectedItem.ToString();
                string search_value = search_text.Text;
                c.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products where " +column+ " like '%" +search_value+ "%'";
                c.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(c);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SearchResult");
                product_grid.DataSource = ds.Tables["SearchResult"];
                product_grid.Refresh();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                if (product_check.Checked)
                {
                    cmd.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products order by product_name";
                }
                else if (price_check.Checked)
                {
                    cmd.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products order by unit_price";
                }
                else if (stock_check.Checked)
                {
                    cmd.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products order by stock";
                }
                else if (shipping_check.Checked)
                {
                    cmd.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products order by shipping_charges";
                }
                else
                {
                    cmd.CommandText = "select product_name as [Product Name], unit_price as [Unit Price], stock as Stock, shipping_charges as [Shipping Fees] from products";
                }

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SearchResult");
                product_grid.DataSource = ds.Tables["SearchResult"];
                product_grid.Refresh();

            }
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void search_column_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void product_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = product_grid.Rows[indexRow];
            product_name_text.Text = row.Cells[0].Value.ToString();
            price_text.Text = row.Cells[1].Value.ToString();
            stockText.Text = row.Cells[2].Value.ToString();
            shipping_rate_text.Text = row.Cells[3].Value.ToString();


        }
    }
}
