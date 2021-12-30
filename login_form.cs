using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burhani_Management_System
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            
            
            if (show_pass_check.Checked)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = password_text.Text;
            if(username == "h" && password == "h")
            {
                //product_retrieval_form product_form = new product_retrieval_form();
                //product_form.Show();
                //product_info product_form = new product_info();
                //product_form.Show();
                //orders_retreive_form order_form = new orders_retreive_form();
                //order_form.Show();
                //orders_form orderForm = new orders_form();
                //orderForm.Show();
                main_app_form main_form = new main_app_form();
                main_form.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");                                                                                                                                        
            }
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

            if (show_pass_check.Checked)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
