
namespace Burhani_Management_System
{
    partial class product_retrieval_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product_retrieval_form));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.search_column_combo = new System.Windows.Forms.ComboBox();
            this.search_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_check = new System.Windows.Forms.CheckBox();
            this.price_check = new System.Windows.Forms.CheckBox();
            this.stock_check = new System.Windows.Forms.CheckBox();
            this.shipping_check = new System.Windows.Forms.CheckBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.product_name_text = new System.Windows.Forms.TextBox();
            this.price_text = new System.Windows.Forms.TextBox();
            this.stockText = new System.Windows.Forms.TextBox();
            this.shipping_rate_text = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Retrieval Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 119);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 22);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 22);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1060, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // product_grid
            // 
            this.product_grid.BackgroundColor = System.Drawing.Color.Plum;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.GridColor = System.Drawing.Color.Violet;
            this.product_grid.Location = new System.Drawing.Point(320, 276);
            this.product_grid.Name = "product_grid";
            this.product_grid.Size = new System.Drawing.Size(769, 249);
            this.product_grid.TabIndex = 5;
            this.product_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by";
            // 
            // search_column_combo
            // 
            this.search_column_combo.FormattingEnabled = true;
            this.search_column_combo.Location = new System.Drawing.Point(33, 192);
            this.search_column_combo.Name = "search_column_combo";
            this.search_column_combo.Size = new System.Drawing.Size(150, 21);
            this.search_column_combo.TabIndex = 7;
            this.search_column_combo.SelectedIndexChanged += new System.EventHandler(this.search_column_combo_SelectedIndexChanged);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(33, 230);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(150, 20);
            this.search_text.TabIndex = 8;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order by ";
            // 
            // product_check
            // 
            this.product_check.AutoSize = true;
            this.product_check.Location = new System.Drawing.Point(246, 192);
            this.product_check.Name = "product_check";
            this.product_check.Size = new System.Drawing.Size(94, 17);
            this.product_check.TabIndex = 10;
            this.product_check.Text = "Product Name";
            this.product_check.UseVisualStyleBackColor = true;
            // 
            // price_check
            // 
            this.price_check.AutoSize = true;
            this.price_check.Location = new System.Drawing.Point(246, 216);
            this.price_check.Name = "price_check";
            this.price_check.Size = new System.Drawing.Size(72, 17);
            this.price_check.TabIndex = 11;
            this.price_check.Text = "Unit Price";
            this.price_check.UseVisualStyleBackColor = true;
            // 
            // stock_check
            // 
            this.stock_check.AutoSize = true;
            this.stock_check.Location = new System.Drawing.Point(246, 240);
            this.stock_check.Name = "stock_check";
            this.stock_check.Size = new System.Drawing.Size(54, 17);
            this.stock_check.TabIndex = 12;
            this.stock_check.Text = "Stock";
            this.stock_check.UseVisualStyleBackColor = true;
            // 
            // shipping_check
            // 
            this.shipping_check.AutoSize = true;
            this.shipping_check.Location = new System.Drawing.Point(358, 192);
            this.shipping_check.Name = "shipping_check";
            this.shipping_check.Size = new System.Drawing.Size(109, 17);
            this.shipping_check.TabIndex = 13;
            this.shipping_check.Text = "Shipping Charges";
            this.shipping_check.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Indigo;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button.Location = new System.Drawing.Point(979, 240);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(110, 30);
            this.search_button.TabIndex = 15;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stock ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Shipping";
            // 
            // product_name_text
            // 
            this.product_name_text.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_text.Location = new System.Drawing.Point(124, 321);
            this.product_name_text.Name = "product_name_text";
            this.product_name_text.Size = new System.Drawing.Size(177, 25);
            this.product_name_text.TabIndex = 20;
            // 
            // price_text
            // 
            this.price_text.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_text.Location = new System.Drawing.Point(124, 355);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(110, 25);
            this.price_text.TabIndex = 21;
            // 
            // stockText
            // 
            this.stockText.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockText.Location = new System.Drawing.Point(124, 390);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(110, 25);
            this.stockText.TabIndex = 22;
            // 
            // shipping_rate_text
            // 
            this.shipping_rate_text.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipping_rate_text.Location = new System.Drawing.Point(124, 423);
            this.shipping_rate_text.Name = "shipping_rate_text";
            this.shipping_rate_text.Size = new System.Drawing.Size(110, 25);
            this.shipping_rate_text.TabIndex = 23;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Indigo;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.Control;
            this.update_button.Location = new System.Drawing.Point(100, 479);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(83, 31);
            this.update_button.TabIndex = 24;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            // 
            // product_retrieval_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 565);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.shipping_rate_text);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.product_name_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.shipping_check);
            this.Controls.Add(this.stock_check);
            this.Controls.Add(this.price_check);
            this.Controls.Add(this.product_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.search_column_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "product_retrieval_form";
            this.Text = "Product Retrieval Form";
            this.Load += new System.EventHandler(this.product_retrieval_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox search_column_combo;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox product_check;
        private System.Windows.Forms.CheckBox price_check;
        private System.Windows.Forms.CheckBox stock_check;
        private System.Windows.Forms.CheckBox shipping_check;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox product_name_text;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.TextBox stockText;
        private System.Windows.Forms.TextBox shipping_rate_text;
        private System.Windows.Forms.Button update_button;
    }
}