namespace Inventory_Management
{
    partial class AttendantInterface
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.attendantsDataGrid = new System.Windows.Forms.DataGridView();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendantProDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ProductTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.removebtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantProDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Location = new System.Drawing.Point(190, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 84);
            this.panel4.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(884, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 56);
            this.button3.TabIndex = 53;
            this.button3.Text = "Close Session";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(361, -3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(300, 84);
            this.button16.TabIndex = 1;
            this.button16.Text = "ATTENDANT";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Inventory_Management.Properties.Resources.shop;
            this.pictureBox4.Location = new System.Drawing.Point(0, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(190, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // attendantsDataGrid
            // 
            this.attendantsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.attendantsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendantsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodname,
            this.price,
            this.qty});
            this.attendantsDataGrid.Location = new System.Drawing.Point(753, 163);
            this.attendantsDataGrid.Name = "attendantsDataGrid";
            this.attendantsDataGrid.ReadOnly = true;
            this.attendantsDataGrid.RowHeadersWidth = 62;
            this.attendantsDataGrid.RowTemplate.Height = 33;
            this.attendantsDataGrid.Size = new System.Drawing.Size(514, 480);
            this.attendantsDataGrid.TabIndex = 48;
            // 
            // prodname
            // 
            this.prodname.HeaderText = "PRODUCT";
            this.prodname.MinimumWidth = 8;
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // qty
            // 
            this.qty.HeaderText = "QUANTITY";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 150;
            // 
            // AttendantProDataGrid
            // 
            this.AttendantProDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendantProDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendantProDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendantProDataGrid.Location = new System.Drawing.Point(0, 148);
            this.AttendantProDataGrid.Name = "AttendantProDataGrid";
            this.AttendantProDataGrid.ReadOnly = true;
            this.AttendantProDataGrid.RowHeadersWidth = 62;
            this.AttendantProDataGrid.RowTemplate.Height = 33;
            this.AttendantProDataGrid.Size = new System.Drawing.Size(363, 560);
            this.AttendantProDataGrid.TabIndex = 51;
            this.AttendantProDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendantProDataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(954, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 52;
            this.button1.Text = "Print Receipt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "AVAILABLE PRODUCTS";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(1002, 113);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(265, 31);
            this.searchtextBox.TabIndex = 54;
            this.searchtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(830, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 34);
            this.button2.TabIndex = 56;
            this.button2.Text = "Search products";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ProductTxtBox
            // 
            this.ProductTxtBox.Location = new System.Drawing.Point(502, 224);
            this.ProductTxtBox.Name = "ProductTxtBox";
            this.ProductTxtBox.Size = new System.Drawing.Size(178, 31);
            this.ProductTxtBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Price";
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Location = new System.Drawing.Point(502, 278);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(178, 31);
            this.PriceTxtBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Quantity";
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Location = new System.Drawing.Point(502, 338);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(178, 31);
            this.QuantityTxtBox.TabIndex = 61;
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.White;
            this.removebtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removebtn.ForeColor = System.Drawing.Color.Black;
            this.removebtn.Location = new System.Drawing.Point(539, 389);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(141, 41);
            this.removebtn.TabIndex = 64;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.Location = new System.Drawing.Point(421, 389);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 41);
            this.AddBtn.TabIndex = 63;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AttendantInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 720);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductTxtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AttendantProDataGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.attendantsDataGrid);
            this.Name = "AttendantInterface";
            this.Text = "AttendantInterface";
            this.Load += new System.EventHandler(this.AttendantInterface_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendantsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantProDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Button button16;
        private PictureBox pictureBox4;
        private DataGridView attendantsDataGrid;
        private DataGridView AttendantProDataGrid;
        private Button button1;
        private Label label3;
        private TextBox searchtextBox;
        private Button button3;
        private Button button2;
        private TextBox ProductTxtBox;
        private Label label1;
        private Label label2;
        private TextBox PriceTxtBox;
        private Label label4;
        private TextBox QuantityTxtBox;
        private Button removebtn;
        private Button AddBtn;
        private DataGridViewTextBoxColumn prodname;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
    }
}