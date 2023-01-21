
namespace Minimarket_Managment
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Selling = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Qty = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.Red;
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(3, 599);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(179, 47);
            this.button_Logout.TabIndex = 24;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Selling
            // 
            this.button_Selling.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Selling.Location = new System.Drawing.Point(3, 152);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(179, 47);
            this.button_Selling.TabIndex = 23;
            this.button_Selling.Text = "Selling";
            this.button_Selling.UseVisualStyleBackColor = true;
            this.button_Selling.Click += new System.EventHandler(this.button_Selling_Click);
            // 
            // button_Product
            // 
            this.button_Product.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Product.Location = new System.Drawing.Point(3, 82);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(179, 47);
            this.button_Product.TabIndex = 22;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkBlue;
            this.title.Location = new System.Drawing.Point(415, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(314, 35);
            this.title.TabIndex = 16;
            this.title.Text = "Categories Manager";
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(70, 553);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(310, 47);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(253, 500);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(127, 47);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(70, 500);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(127, 47);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(162, 188);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(247, 30);
            this.textBox_Description.TabIndex = 8;
            // 
            // label_Qty
            // 
            this.label_Qty.AutoSize = true;
            this.label_Qty.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Qty.Location = new System.Drawing.Point(18, 189);
            this.label_Qty.Name = "label_Qty";
            this.label_Qty.Size = new System.Drawing.Size(137, 26);
            this.label_Qty.TabIndex = 7;
            this.label_Qty.Text = "Description";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(162, 134);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(247, 30);
            this.textBox_Name.TabIndex = 4;
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
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(162, 81);
            this.textBox_Id.Multiline = true;
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(247, 30);
            this.textBox_Id.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.dataGridView_Category);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.label_Qty);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label_Id);
            this.panel1.Location = new System.Drawing.Point(194, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 653);
            this.panel1.TabIndex = 20;
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(138)))), ((int)(((byte)(209)))));
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(963, 606);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(127, 36);
            this.button_Refresh.TabIndex = 19;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Category.ColumnHeadersHeight = 29;
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Category.Location = new System.Drawing.Point(415, 81);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_Category.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Category.RowTemplate.Height = 24;
            this.dataGridView_Category.Size = new System.Drawing.Size(675, 519);
            this.dataGridView_Category.TabIndex = 18;
            
            this.dataGridView_Category.Click += new System.EventHandler(this.dataGridView_Category_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Red;
            this.label_exit.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_exit.Location = new System.Drawing.Point(1283, 1);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(28, 25);
            this.label_exit.TabIndex = 25;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 35);
            this.label4.TabIndex = 35;
            this.label4.Text = "Category";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1311, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Selling;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Qty;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        protected System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Refresh;
    }
}