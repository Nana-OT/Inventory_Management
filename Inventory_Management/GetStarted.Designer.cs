namespace Inventory_Management
{
    partial class GetStartedForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStartedForm));
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bgImage
            // 
            this.bgImage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bgImage.BackgroundImage = global::Inventory_Management.Properties.Resources.image_1;
            this.bgImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bgImage.Image = global::Inventory_Management.Properties.Resources.image_1;
            this.bgImage.Location = new System.Drawing.Point(0, 1);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1279, 726);
            this.bgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgImage.TabIndex = 0;
            this.bgImage.TabStop = false;
            this.bgImage.Click += new System.EventHandler(this.bgImage_Click);
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Snow;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbtn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startbtn.ForeColor = System.Drawing.Color.Red;
            this.startbtn.Location = new System.Drawing.Point(943, 638);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(194, 70);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // GetStartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 720);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.bgImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetStartedForm";
            this.Text = "Get Started";
            this.Load += new System.EventHandler(this.GetStartedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox bgImage;
        private Button startbtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}