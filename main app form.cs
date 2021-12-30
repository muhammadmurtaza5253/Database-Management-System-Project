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
    public partial class main_app_form : Form
    {
        SqlConnection con;
        public main_app_form()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Burhani Management System";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "select sum(price - (quantity*unit_price)) as [Total Profit / Month] from orders join order_details on order_details.orders_id = orders.id join products on products.id = order_details.products_id where day(order_date) <= day(GETDATE()) and month(order_date) = month(getdate()) and year(order_date) = year(getdate())";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SearchResult");
            profit_grid.DataSource = ds.Tables["SearchResult"];
            profit_grid.Refresh();

            cmd.CommandText = "select sum(price) as [Total Sales / Month] from order_details join orders on orders.id = order_details.orders_id where day(order_date) <= day(GETDATE()) and month(order_date) = month(getdate()) and year(order_date) = year(getdate()) ";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sales_adapter = new SqlDataAdapter(cmd);
            DataSet sales_ds = new DataSet();
            sales_adapter.Fill(sales_ds, "Search_Result_1");
            sales_grid.DataSource = sales_ds.Tables["Search_Result_1"];
            sales_grid.Refresh();

            cmd.CommandText = "select distinct count(id) as [Total Orders / Month] from orders where day(order_date) <= day(GETDATE()) and month(order_date) = month(getdate()) and year(order_date) = year(getdate())";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter orders_adapter = new SqlDataAdapter(cmd);
            DataSet orders_ds = new DataSet();
            orders_adapter.Fill(orders_ds, "Search_Result_2");
            orders_grid.DataSource = orders_ds.Tables["Search_Result_2"];
            orders_grid.Refresh();

            cmd.CommandText = "select distinct count(id) as [Total Orders Shipped] from orders";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter total_orders_adapter = new SqlDataAdapter(cmd);
            DataSet total_ds = new DataSet();
            total_orders_adapter.Fill(total_ds, "Search_Result_3");
            total_orders_grid.DataSource = total_ds.Tables["Search_Result_3"];
            total_orders_grid.Refresh();


        }

        private void products_button_Click(object sender, EventArgs e)
        {
            product_info product_form = new product_info();
            product_form.Show();
        }

        private void orders_button_Click(object sender, EventArgs e)
        {
            orders_form orderForm = new orders_form();
            orderForm.Show();
        }
    }
}
