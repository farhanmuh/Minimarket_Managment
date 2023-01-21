
namespace Minimarket_Managment
{
    partial class EmployeForm
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
            this.label_exit = new System.Windows.Forms.Label();
            this.dataGridView_Employe = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Nohp = new System.Windows.Forms.TextBox();
            this.button_Selling = new System.Windows.Forms.Button();
            this.button_Category = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.label_Qty = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Idemploye = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_Nameemploye = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Red;
            this.label_exit.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_exit.Location = new System.Drawing.Point(1281, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 25);
            this.label_exit.TabIndex = 26;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // dataGridView_Employe
            // 
            this.dataGridView_Employe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Employe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employe.Location = new System.Drawing.Point(421, 81);
            this.dataGridView_Employe.Name = "dataGridView_Employe";
            this.dataGridView_Employe.RowHeadersWidth = 51;
            this.dataGridView_Employe.RowTemplate.Height = 24;
            this.dataGridView_Employe.Size = new System.Drawing.Size(675, 519);
            this.dataGridView_Employe.TabIndex = 17;
            
            this.dataGridView_Employe.Click += new System.EventHandler(this.dataGridView_Employe_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkBlue;
            this.title.Location = new System.Drawing.Point(415, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(286, 35);
            this.title.TabIndex = 16;
            this.title.Text = "Employe Manager";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(138)))), ((int)(((byte)(209)))));
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(969, 606);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(127, 36);
            this.button_Refresh.TabIndex = 15;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(59, 553);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(310, 47);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(242, 500);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(127, 47);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(59, 500);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(127, 47);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Nohp
            // 
            this.textBox_Nohp.Location = new System.Drawing.Point(150, 237);
            this.textBox_Nohp.Multiline = true;
            this.textBox_Nohp.Name = "textBox_Nohp";
            this.textBox_Nohp.Size = new System.Drawing.Size(247, 30);
            this.textBox_Nohp.TabIndex = 8;
            // 
            // button_Selling
            // 
            this.button_Selling.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Selling.Location = new System.Drawing.Point(4, 205);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(179, 47);
            this.button_Selling.TabIndex = 24;
            this.button_Selling.Text = "Selling";
            this.button_Selling.UseVisualStyleBackColor = true;
            this.button_Selling.Click += new System.EventHandler(this.button_Selling_Click);
            // 
            // button_Category
            // 
            this.button_Category.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Category.Location = new System.Drawing.Point(3, 143);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(179, 47);
            this.button_Category.TabIndex = 23;
            this.button_Category.Text = "Category";
            this.button_Category.UseVisualStyleBackColor = true;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // button_Product
            // 
            this.button_Product.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Product.Location = new System.Drawing.Point(4, 81);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(179, 47);
            this.button_Product.TabIndex = 22;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // label_Qty
            // 
            this.label_Qty.AutoSize = true;
            this.label_Qty.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Qty.Location = new System.Drawing.Point(24, 237);
            this.label_Qty.Name = "label_Qty";
            this.label_Qty.Size = new System.Drawing.Size(80, 26);
            this.label_Qty.TabIndex = 7;
            this.label_Qty.Text = "Phone";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(150, 183);
            this.textBox_Age.Multiline = true;
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(247, 30);
            this.textBox_Age.TabIndex = 6;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(24, 183);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(53, 26);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Age";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(24, 134);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(74, 26);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name";
            // 
            // textBox_Idemploye
            // 
            this.textBox_Idemploye.Location = new System.Drawing.Point(150, 81);
            this.textBox_Idemploye.Multiline = true;
            this.textBox_Idemploye.Name = "textBox_Idemploye";
            this.textBox_Idemploye.Size = new System.Drawing.Size(247, 30);
            this.textBox_Idemploye.TabIndex = 2;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(24, 81);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(41, 26);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id ";
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.Red;
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(3, 598);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(179, 47);
            this.button_Logout.TabIndex = 25;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // textBox_Nameemploye
            // 
            this.textBox_Nameemploye.Location = new System.Drawing.Point(150, 134);
            this.textBox_Nameemploye.Multiline = true;
            this.textBox_Nameemploye.Name = "textBox_Nameemploye";
            this.textBox_Nameemploye.Size = new System.Drawing.Size(247, 30);
            this.textBox_Nameemploye.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.dataGridView_Employe);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_Nohp);
            this.panel1.Controls.Add(this.label_Qty);
            this.panel1.Controls.Add(this.textBox_Age);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.textBox_Nameemploye);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.textBox_Idemploye);
            this.panel1.Controls.Add(this.label_Id);
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 653);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 35);
            this.label4.TabIndex = 37;
            this.label4.Text = "Employe";
            // 
            // EmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1311, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeForm";
            this.Load += new System.EventHandler(this.EmployeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.DataGridView dataGridView_Employe;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Nohp;
        private System.Windows.Forms.Button button_Selling;
        private System.Windows.Forms.Button button_Category;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Label label_Qty;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Idemploye;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.TextBox textBox_Nameemploye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}