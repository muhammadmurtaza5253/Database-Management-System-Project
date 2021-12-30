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
    public partial class orders_retreive_form : Form
    {
        SqlConnection con;
        public orders_retreive_form()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Burhani Management System";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'orders'";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                search_column_combo.Items.Add(rd["COLUMN_NAME"]);
            }
            rd.Close();
        }

        private void orders_retreive_form_Load(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            bool check_date = date_find_check.Checked;
            bool search_status = search_column_combo.SelectedIndex > -1;
            bool order_customer = customer_check.Checked;
            //bool order_amount = amount_check.Checked;
            bool order_date = date_check.Checked;
            //bool order_profit = profit_check.Checked;
            bool order_status = order_customer || order_date; 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (search_status && order_status && check_date)
            {
                string order = "";
                string column = search_column_combo.SelectedItem.ToString();
                string search_value = search_text.Text;
                if (order_customer)
                {
                    order = "";
                    order += "customer_name";
                }
                else if (order_date)
                {
                    order = "";
                    order += "order_date";
                }
                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders where " + column + " like '%" + search_value + "%' and order_date >= '"+to_date_picker.Value+"' and order_date <= '"+from_date_picker.Value+"' order by "+order+"";
            }
            else if(search_status && order_status)
            {
                string order = "";
                string column = search_column_combo.SelectedItem.ToString();
                string search_value = search_text.Text;
                if (order_customer)
                {
                    order = "";
                    order += "customer_name";
                }

                else if (order_date)
                {
                    order = "";
                    order += "order_date";
                }

                cmd.CommandText = "select customer_name, address, order_date,  delivery_status from orders where " + column + " like '%" + search_value + "%' order by "+order+"";

            }
           else if (search_status)
            {
                string column = search_column_combo.SelectedItem.ToString();
                string search_value = search_text.Text;

                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders where " + column + " like '%" + search_value + "%'";
            }
            else if (order_status)
            {
                string order = "";
                if (order_customer)
                {
                    order = "";
                    order += "customer_name";
                }
                
                else if (order_date)
                {
                    order = "";
                    order += "order_date";
                }

                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders order by " + order + "";
            }
            else if (check_date)
            {
                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders where order_date >= '" + to_date_picker.Value + "' and order_date <= '" + from_date_picker.Value + "'";
            }
            else if(order_status && check_date)
            {
                string order = "";
                if (order_customer)
                {
                    order = "";
                    order += "customer_name";
                }

                else if (order_date)
                {
                    order = "";
                    order += "order_date";
                }
                
                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders where order_date >= '" + to_date_picker.Value + "' and order_date <= '" + from_date_picker.Value + "' order by "+order+"";
            }
            else if(search_status && check_date)
            {
                string column = search_column_combo.SelectedItem.ToString();
                string search_value = search_text.Text;

                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders where " + column + " like '%" + search_value + "%' and order_date >= '" + to_date_picker.Value + "' and order_date <= '" + from_date_picker.Value + "'";

            }
            else
            {
                cmd.CommandText = "select customer_name, address, order_date, delivery_status from orders";
            }

                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SearchResult");
                orders_grid.DataSource = ds.Tables["SearchResult"];
                orders_grid.Refresh();
                search_column_combo.Text = "";
            search_text.Text = "";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            orders_grid.Refresh();
            search_column_combo.Text = "";
            search_text.Text = "";
            


        }
    }
}
