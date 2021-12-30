
namespace Burhani_Management_System
{
    partial class orders_retreive_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders_retreive_form));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_button = new System.Windows.Forms.Button();
            this.date_check = new System.Windows.Forms.CheckBox();
            this.customer_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.search_column_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orders_grid = new System.Windows.Forms.DataGridView();
            this.from_date_picker = new System.Windows.Forms.DateTimePicker();
            this.to_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_find_check = new System.Windows.Forms.CheckBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orders Retrieval Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 119);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Indigo;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button.Location = new System.Drawing.Point(985, 238);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(110, 30);
            this.search_button.TabIndex = 34;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // date_check
            // 
            this.date_check.AutoSize = true;
            this.date_check.Location = new System.Drawing.Point(264, 226);
            this.date_check.Name = "date_check";
            this.date_check.Size = new System.Drawing.Size(84, 17);
            this.date_check.TabIndex = 32;
            this.date_check.Text = "Date/Month";
            this.date_check.UseVisualStyleBackColor = true;
            // 
            // customer_check
            // 
            this.customer_check.AutoSize = true;
            this.customer_check.Location = new System.Drawing.Point(264, 199);
            this.customer_check.Name = "customer_check";
            this.customer_check.Size = new System.Drawing.Size(101, 17);
            this.customer_check.TabIndex = 30;
            this.customer_check.Text = "Customer Name";
            this.customer_check.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Order by ";
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(51, 237);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(150, 20);
            this.search_text.TabIndex = 28;
            // 
            // search_column_combo
            // 
            this.search_column_combo.FormattingEnabled = true;
            this.search_column_combo.Location = new System.Drawing.Point(51, 199);
            this.search_column_combo.Name = "search_column_combo";
            this.search_column_combo.Size = new System.Drawing.Size(150, 21);
            this.search_column_combo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search by";
            // 
            // orders_grid
            // 
            this.orders_grid.BackgroundColor = System.Drawing.Color.Plum;
            this.orders_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_grid.GridColor = System.Drawing.Color.Violet;
            this.orders_grid.Location = new System.Drawing.Point(39, 284);
            this.orders_grid.Name = "orders_grid";
            this.orders_grid.Size = new System.Drawing.Size(1056, 204);
            this.orders_grid.TabIndex = 25;
            // 
            // from_date_picker
            // 
            this.from_date_picker.Location = new System.Drawing.Point(468, 223);
            this.from_date_picker.Name = "from_date_picker";
            this.from_date_picker.Size = new System.Drawing.Size(200, 20);
            this.from_date_picker.TabIndex = 35;
            // 
            // to_date_picker
            // 
            this.to_date_picker.Location = new System.Drawing.Point(699, 223);
            this.to_date_picker.Name = "to_date_picker";
            this.to_date_picker.Size = new System.Drawing.Size(200, 20);
            this.to_date_picker.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(696, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date";
            // 
            // date_find_check
            // 
            this.date_find_check.AutoSize = true;
            this.date_find_check.Location = new System.Drawing.Point(468, 250);
            this.date_find_check.Name = "date_find_check";
            this.date_find_check.Size = new System.Drawing.Size(82, 17);
            this.date_find_check.TabIndex = 42;
            this.date_find_check.Text = "Select Date";
            this.date_find_check.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Indigo;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.SystemColors.Control;
            this.clear_button.Location = new System.Drawing.Point(12, 35);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(88, 31);
            this.clear_button.TabIndex = 44;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 30);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(-5, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 30);
            this.panel2.TabIndex = 46;
            // 
            // orders_retreive_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.date_find_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.to_date_picker);
            this.Controls.Add(this.from_date_picker);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.date_check);
            this.Controls.Add(this.customer_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.search_column_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orders_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "orders_retreive_form";
            this.Text = "Orders Form";
            this.Load += new System.EventHandler(this.orders_retreive_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.CheckBox date_check;
        private System.Windows.Forms.CheckBox customer_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.ComboBox search_column_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orders_grid;
        private System.Windows.Forms.DateTimePicker from_date_picker;
        private System.Windows.Forms.DateTimePicker to_date_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox date_find_check;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}