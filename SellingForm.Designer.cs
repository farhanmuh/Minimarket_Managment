
namespace Minimarket_Managment
{
    partial class SellingForm
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
            this.label_Qty = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Selling = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Seller = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texrBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Employe = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddtoBill = new System.Windows.Forms.Button();
            this.textBox_IdtoBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.dataGridView_SellList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SellList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.label_exit.TabIndex = 32;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_Qty
            // 
            this.label_Qty.AutoSize = true;
            this.label_Qty.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Qty.Location = new System.Drawing.Point(27, 230);
            this.label_Qty.Name = "label_Qty";
            this.label_Qty.Size = new System.Drawing.Size(0, 26);
            this.label_Qty.TabIndex = 7;
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.White;
            this.textBox_Price.Location = new System.Drawing.Point(153, 176);
            this.textBox_Price.Multiline = true;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.Size = new System.Drawing.Size(247, 30);
            this.textBox_Price.TabIndex = 6;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(27, 176);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(69, 26);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Price";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(153, 126);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(247, 30);
            this.textBox_Name.TabIndex = 2;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(27, 126);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(74, 26);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // button_Selling
            // 
            this.button_Selling.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Selling.Location = new System.Drawing.Point(6, 156);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(179, 47);
            this.button_Selling.TabIndex = 30;
            this.button_Selling.Text = "Category";
            this.button_Selling.UseVisualStyleBackColor = true;
            this.button_Selling.Click += new System.EventHandler(this.button_Selling_Click);
            // 
            // button_Product
            // 
            this.button_Product.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Product.Location = new System.Drawing.Point(6, 81);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(179, 47);
            this.button_Product.TabIndex = 28;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProdName,
            this.ProdPrice,
            this.ProdQuantity,
            this.Total});
            this.dataGridView_Order.Location = new System.Drawing.Point(414, 80);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(673, 186);
            this.dataGridView_Order.TabIndex = 17;
            this.dataGridView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Order_CellContentClick);
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "Prod ID";
            this.ProdID.MinimumWidth = 6;
            this.ProdID.Name = "ProdID";
            this.ProdID.Width = 125;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Prod Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 125;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "Prod Price";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Width = 125;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.HeaderText = "Prod Quantity";
            this.ProdQuantity.MinimumWidth = 6;
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkBlue;
            this.title.Location = new System.Drawing.Point(483, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(119, 35);
            this.title.TabIndex = 16;
            this.title.Text = "Selling";
            // 
            // button_Logout
            // 
            this.button_Logout.AutoEllipsis = true;
            this.button_Logout.BackColor = System.Drawing.Color.Red;
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(7, 599);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(179, 47);
            this.button_Logout.TabIndex = 31;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.BackColor = System.Drawing.Color.White;
            this.textBox_Quantity.Location = new System.Drawing.Point(153, 230);
            this.textBox_Quantity.Multiline = true;
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(247, 30);
            this.textBox_Quantity.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_Seller);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.texrBox_Id);
            this.panel1.Controls.Add(this.label_Id);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Controls.Add(this.label_Employe);
            this.panel1.Controls.Add(this.button_Print);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_AddtoBill);
            this.panel1.Controls.Add(this.textBox_IdtoBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.comboBox_Category);
            this.panel1.Controls.Add(this.button_AddOrder);
            this.panel1.Controls.Add(this.dataGridView_Product);
            this.panel1.Controls.Add(this.dataGridView_SellList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_Order);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.textBox_Quantity);
            this.panel1.Controls.Add(this.label_Qty);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(196, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 652);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(138)))), ((int)(((byte)(209)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(835, 594);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(117, 47);
            this.button_Delete.TabIndex = 38;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(710, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Seller";
            // 
            // label_Seller
            // 
            this.label_Seller.AutoSize = true;
            this.label_Seller.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Seller.Location = new System.Drawing.Point(112, 32);
            this.label_Seller.Name = "label_Seller";
            this.label_Seller.Size = new System.Drawing.Size(74, 26);
            this.label_Seller.TabIndex = 35;
            this.label_Seller.Text = "Seller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(864, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "  Date:";
            // 
            // texrBox_Id
            // 
            this.texrBox_Id.BackColor = System.Drawing.Color.White;
            this.texrBox_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texrBox_Id.Location = new System.Drawing.Point(153, 80);
            this.texrBox_Id.Multiline = true;
            this.texrBox_Id.Name = "texrBox_Id";
            this.texrBox_Id.Size = new System.Drawing.Size(247, 30);
            this.texrBox_Id.TabIndex = 33;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(27, 80);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(35, 26);
            this.label_Id.TabIndex = 32;
            this.label_Id.Text = "Id";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(965, 51);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(80, 26);
            this.label_Date.TabIndex = 31;
            this.label_Date.Text = "  Date:";
            // 
            // label_Employe
            // 
            this.label_Employe.AutoSize = true;
            this.label_Employe.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Employe.Location = new System.Drawing.Point(27, 32);
            this.label_Employe.Name = "label_Employe";
            this.label_Employe.Size = new System.Drawing.Size(48, 26);
            this.label_Employe.TabIndex = 30;
            this.label_Employe.Text = "      ";
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(182)))), ((int)(((byte)(83)))));
            this.button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(970, 594);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(117, 47);
            this.button_Print.TabIndex = 28;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Id ";
            // 
            // button_AddtoBill
            // 
            this.button_AddtoBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button_AddtoBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_AddtoBill.FlatAppearance.BorderSize = 0;
            this.button_AddtoBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddtoBill.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddtoBill.Location = new System.Drawing.Point(970, 391);
            this.button_AddtoBill.Name = "button_AddtoBill";
            this.button_AddtoBill.Size = new System.Drawing.Size(117, 47);
            this.button_AddtoBill.TabIndex = 26;
            this.button_AddtoBill.Text = "Add to Bil";
            this.button_AddtoBill.UseVisualStyleBackColor = false;
            this.button_AddtoBill.Click += new System.EventHandler(this.button_AddtoBill_Click);
            // 
            // textBox_IdtoBill
            // 
            this.textBox_IdtoBill.BackColor = System.Drawing.Color.White;
            this.textBox_IdtoBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IdtoBill.Location = new System.Drawing.Point(714, 401);
            this.textBox_IdtoBill.Multiline = true;
            this.textBox_IdtoBill.Name = "textBox_IdtoBill";
            this.textBox_IdtoBill.Size = new System.Drawing.Size(247, 30);
            this.textBox_IdtoBill.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sells List";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(138)))), ((int)(((byte)(209)))));
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(279, 396);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(117, 40);
            this.button_Refresh.TabIndex = 23;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("News706 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(28, 401);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(244, 28);
            this.comboBox_Category.TabIndex = 22;
            this.comboBox_Category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Category_SelectionChangeCommitted);
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button_AddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_AddOrder.FlatAppearance.BorderSize = 0;
            this.button_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOrder.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddOrder.Location = new System.Drawing.Point(283, 279);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(117, 47);
            this.button_AddOrder.TabIndex = 21;
            this.button_AddOrder.Text = "Add";
            this.button_AddOrder.UseVisualStyleBackColor = false;
            this.button_AddOrder.Click += new System.EventHandler(this.button_AddOrder_Click);
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(28, 442);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowHeadersWidth = 51;
            this.dataGridView_Product.RowTemplate.Height = 24;
            this.dataGridView_Product.Size = new System.Drawing.Size(368, 186);
            this.dataGridView_Product.TabIndex = 20;
            
            this.dataGridView_Product.Click += new System.EventHandler(this.dataGridView_Product_Click);
            // 
            // dataGridView_SellList
            // 
            this.dataGridView_SellList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SellList.Location = new System.Drawing.Point(414, 442);
            this.dataGridView_SellList.Name = "dataGridView_SellList";
            this.dataGridView_SellList.RowHeadersWidth = 51;
            this.dataGridView_SellList.RowTemplate.Height = 24;
            this.dataGridView_SellList.Size = new System.Drawing.Size(673, 146);
            this.dataGridView_SellList.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label_Amount);
            this.panel2.Location = new System.Drawing.Point(812, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 37);
            this.panel2.TabIndex = 37;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("News706 BT", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.Location = new System.Drawing.Point(31, 7);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(96, 26);
            this.label_Amount.TabIndex = 29;
            this.label_Amount.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(33, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 34;
            this.label4.Text = "Selling";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1311, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SellList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_Qty;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Selling;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.DataGridView dataGridView_SellList;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddtoBill;
        private System.Windows.Forms.TextBox textBox_IdtoBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_Employe;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.TextBox texrBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Seller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button1;
    }
}