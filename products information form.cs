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
    public partial class product_info : Form
    {
        SqlConnection con;
        public product_info()
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
                field_combo.Items.Add(rd["COLUMN_NAME"]);
            }
            rd.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update products set " + field_combo.SelectedItem + " = '" + newValue_text.Text + "' where " + field_combo.SelectedItem + " = '" + oldValue_combo.SelectedItem + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully!");
        }

        private void field_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            oldValue_combo.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select " + field_combo.SelectedItem.ToString() + " as field from products";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                oldValue_combo.Items.Add(rd["field"]);
            }
            rd.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            product_retrieval_form form = new product_retrieval_form();
            form.Show();
        }

        private void submit_button_insert_Click(object sender, EventArgs e)
        {
            string name = productName_text.Text;
            string price = price_text.Text;
            string stock = stock_text.Text;
            string shipping = shipping_text.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into products(product_name, unit_price, stock, shipping_charges) values('" + name + "','" + price + "','" + stock + "','" + shipping + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Succesfully!");
        }
    }
}
