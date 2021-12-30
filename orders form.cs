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
    public partial class orders_form : Form
    {
        SqlConnection con; 
        public orders_form()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Burhani Management System";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select product_name from products";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                products_combo.Items.Add(rd["product_name"]);
            }
            rd.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void orders_form_Load(object sender, EventArgs e)
        {

        }

        private void submit_button_insert_Click(object sender, EventArgs e)
        {
            //SqlCommand orderID = new SqlCommand();
            //orderID.Connection = con;
            //orderID.CommandText = "select top 1 id from orders order by id desc";
            //orderID.CommandType = CommandType.Text;
            //SqlDataReader rd_ID = orderID.ExecuteReader();
            
            
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into orders(customer_name, address, order_date, delivery_status) values('" + customer_name_text.Text + "','"+address_text.Text+"','"+dateTimePicker1.Value+"','"+delivery_status_text.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer details enter succesfully!");
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            products_list_box.Items.Add(products_combo.SelectedItem);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void enter_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select top 1 id from Orders order by id desc";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rdd = cmd.ExecuteReader();
            string order_id = "";
            while (rdd.Read())
            {
                if (rdd["id"].ToString() != "")
                {
                    order_id = rdd["id"].ToString();
                    break;
                }
            }
            rdd.Close();

            int counter = products_list_box.Items.Count - 1;
            string prod_id = "";
            string quant;
            string price;
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandText = "select id, product_name from products";
            cm.CommandType = CommandType.Text;
            while(counter > -1)
            {
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read())
                {
                    if(rd["product_name"].ToString() == products_list_box.Items[counter].ToString())
                    {
                        prod_id = rd["id"].ToString();
                    }
                }
                rd.Close();
                quant = quantity_list_box.Items[counter].ToString();
                price = price_list_box.Items[counter].ToString();
                counter -= 1;
                SqlCommand c = new SqlCommand();
                c.Connection = con;
                c.CommandText = "insert into order_details(orders_id,products_id,quantity,price) values('" + order_id + "','" + prod_id + "','" + quant + "','" + price + "')";
                c.CommandType = CommandType.Text;
                c.ExecuteNonQuery();
            }
            MessageBox.Show("Order Details entered succesfully!");
            
        }

        private void quantity_list_button_Click(object sender, EventArgs e)
        {
            quantity_list_box.Items.Add(quantity_text.Text);
        }

        private void price_list_button_Click(object sender, EventArgs e)
        {
            price_list_box.Items.Add(price_text.Text);
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            orders_retreive_form retrieveForm = new orders_retreive_form();
            retrieveForm.Show();
        }
    }
}
