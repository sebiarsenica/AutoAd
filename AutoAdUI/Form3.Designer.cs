
namespace AutoAdUI
{
    partial class Form3
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
            this.button_Close = new System.Windows.Forms.Button();
            this.dataGridView_Ads = new System.Windows.Forms.DataGridView();
            this.pictureBox_ViewPhoto = new System.Windows.Forms.PictureBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_PreviousPicture = new System.Windows.Forms.Button();
            this.button_NextPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_OnlySellAds = new System.Windows.Forms.Button();
            this.button_ShowRentAds = new System.Windows.Forms.Button();
            this.button_SearchByYear = new System.Windows.Forms.Button();
            this.button_SearchByPrice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Maxim = new System.Windows.Forms.TextBox();
            this.textBox_Minim = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_OrderByPrice = new System.Windows.Forms.Button();
            this.button_OrderByYear = new System.Windows.Forms.Button();
            this.textBox_ModelSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_SearchByModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Close.Location = new System.Drawing.Point(1053, 1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(45, 23);
            this.button_Close.TabIndex = 18;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dataGridView_Ads
            // 
            this.dataGridView_Ads.AllowUserToAddRows = false;
            this.dataGridView_Ads.AllowUserToDeleteRows = false;
            this.dataGridView_Ads.AllowUserToResizeColumns = false;
            this.dataGridView_Ads.AllowUserToResizeRows = false;
            this.dataGridView_Ads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Ads.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Ads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ads.Location = new System.Drawing.Point(33, 21);
            this.dataGridView_Ads.Name = "dataGridView_Ads";
            this.dataGridView_Ads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ads.Size = new System.Drawing.Size(845, 168);
            this.dataGridView_Ads.TabIndex = 21;
            this.dataGridView_Ads.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ads_CellClick);
            // 
            // pictureBox_ViewPhoto
            // 
            this.pictureBox_ViewPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_ViewPhoto.Location = new System.Drawing.Point(26, 0);
            this.pictureBox_ViewPhoto.Name = "pictureBox_ViewPhoto";
            this.pictureBox_ViewPhoto.Size = new System.Drawing.Size(442, 330);
            this.pictureBox_ViewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ViewPhoto.TabIndex = 22;
            this.pictureBox_ViewPhoto.TabStop = false;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(918, 166);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(114, 23);
            this.button_Remove.TabIndex = 23;
            this.button_Remove.Text = "Remove Ad";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.button_PreviousPicture);
            this.panel1.Controls.Add(this.button_NextPicture);
            this.panel1.Controls.Add(this.pictureBox_ViewPhoto);
            this.panel1.Location = new System.Drawing.Point(33, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 333);
            this.panel1.TabIndex = 24;
            // 
            // button_PreviousPicture
            // 
            this.button_PreviousPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_PreviousPicture.Location = new System.Drawing.Point(0, 0);
            this.button_PreviousPicture.Name = "button_PreviousPicture";
            this.button_PreviousPicture.Size = new System.Drawing.Size(28, 333);
            this.button_PreviousPicture.TabIndex = 26;
            this.button_PreviousPicture.Text = "<-";
            this.button_PreviousPicture.UseVisualStyleBackColor = true;
            this.button_PreviousPicture.Click += new System.EventHandler(this.button_PreviousPicture_Click);
            // 
            // button_NextPicture
            // 
            this.button_NextPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NextPicture.Location = new System.Drawing.Point(465, 0);
            this.button_NextPicture.Name = "button_NextPicture";
            this.button_NextPicture.Size = new System.Drawing.Size(28, 333);
            this.button_NextPicture.TabIndex = 25;
            this.button_NextPicture.Text = "->";
            this.button_NextPicture.UseVisualStyleBackColor = true;
            this.button_NextPicture.Click += new System.EventHandler(this.button_NextPicture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_OnlySellAds);
            this.groupBox1.Controls.Add(this.button_ShowRentAds);
            this.groupBox1.Controls.Add(this.button_SearchByYear);
            this.groupBox1.Controls.Add(this.button_SearchByPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Maxim);
            this.groupBox1.Controls.Add(this.textBox_Minim);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(618, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 181);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // button_OnlySellAds
            // 
            this.button_OnlySellAds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_OnlySellAds.Location = new System.Drawing.Point(3, 132);
            this.button_OnlySellAds.Name = "button_OnlySellAds";
            this.button_OnlySellAds.Size = new System.Drawing.Size(408, 23);
            this.button_OnlySellAds.TabIndex = 32;
            this.button_OnlySellAds.Text = "Show Sell Ads";
            this.button_OnlySellAds.UseVisualStyleBackColor = true;
            this.button_OnlySellAds.Click += new System.EventHandler(this.button_OnlySellAds_Click);
            // 
            // button_ShowRentAds
            // 
            this.button_ShowRentAds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_ShowRentAds.Location = new System.Drawing.Point(3, 155);
            this.button_ShowRentAds.Name = "button_ShowRentAds";
            this.button_ShowRentAds.Size = new System.Drawing.Size(408, 23);
            this.button_ShowRentAds.TabIndex = 31;
            this.button_ShowRentAds.Text = "Show Rent Ads";
            this.button_ShowRentAds.UseVisualStyleBackColor = true;
            this.button_ShowRentAds.Click += new System.EventHandler(this.button_ShowRentAds_Click);
            // 
            // button_SearchByYear
            // 
            this.button_SearchByYear.Location = new System.Drawing.Point(0, 91);
            this.button_SearchByYear.Name = "button_SearchByYear";
            this.button_SearchByYear.Size = new System.Drawing.Size(414, 23);
            this.button_SearchByYear.TabIndex = 30;
            this.button_SearchByYear.Text = "Search By Year";
            this.button_SearchByYear.UseVisualStyleBackColor = true;
            this.button_SearchByYear.Click += new System.EventHandler(this.button_SearchByYear_Click);
            // 
            // button_SearchByPrice
            // 
            this.button_SearchByPrice.Location = new System.Drawing.Point(0, 71);
            this.button_SearchByPrice.Name = "button_SearchByPrice";
            this.button_SearchByPrice.Size = new System.Drawing.Size(414, 23);
            this.button_SearchByPrice.TabIndex = 29;
            this.button_SearchByPrice.Text = "Search By Price";
            this.button_SearchByPrice.UseVisualStyleBackColor = true;
            this.button_SearchByPrice.Click += new System.EventHandler(this.button_SearchByPrice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Maxim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Minim:";
            // 
            // textBox_Maxim
            // 
            this.textBox_Maxim.Location = new System.Drawing.Point(270, 43);
            this.textBox_Maxim.Name = "textBox_Maxim";
            this.textBox_Maxim.Size = new System.Drawing.Size(100, 20);
            this.textBox_Maxim.TabIndex = 26;
            // 
            // textBox_Minim
            // 
            this.textBox_Minim.Location = new System.Drawing.Point(47, 43);
            this.textBox_Minim.Name = "textBox_Minim";
            this.textBox_Minim.Size = new System.Drawing.Size(100, 20);
            this.textBox_Minim.TabIndex = 0;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(918, 120);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(114, 23);
            this.button_Refresh.TabIndex = 26;
            this.button_Refresh.Text = "Remove Filters";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_OrderByPrice
            // 
            this.button_OrderByPrice.Location = new System.Drawing.Point(918, 21);
            this.button_OrderByPrice.Name = "button_OrderByPrice";
            this.button_OrderByPrice.Size = new System.Drawing.Size(114, 23);
            this.button_OrderByPrice.TabIndex = 27;
            this.button_OrderByPrice.Text = "Order By Price";
            this.button_OrderByPrice.UseVisualStyleBackColor = true;
            this.button_OrderByPrice.Click += new System.EventHandler(this.button_OrderByPrice_Click);
            // 
            // button_OrderByYear
            // 
            this.button_OrderByYear.Location = new System.Drawing.Point(918, 71);
            this.button_OrderByYear.Name = "button_OrderByYear";
            this.button_OrderByYear.Size = new System.Drawing.Size(114, 23);
            this.button_OrderByYear.TabIndex = 28;
            this.button_OrderByYear.Text = "Order By Year";
            this.button_OrderByYear.UseVisualStyleBackColor = true;
            this.button_OrderByYear.Click += new System.EventHandler(this.button_OrderByYear_Click);
            // 
            // textBox_ModelSearch
            // 
            this.textBox_ModelSearch.Location = new System.Drawing.Point(0, 30);
            this.textBox_ModelSearch.Name = "textBox_ModelSearch";
            this.textBox_ModelSearch.Size = new System.Drawing.Size(414, 20);
            this.textBox_ModelSearch.TabIndex = 31;
            this.textBox_ModelSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_SearchByModel);
            this.groupBox2.Controls.Add(this.textBox_ModelSearch);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(621, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Model";
            // 
            // button_SearchByModel
            // 
            this.button_SearchByModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_SearchByModel.Location = new System.Drawing.Point(3, 74);
            this.button_SearchByModel.Name = "button_SearchByModel";
            this.button_SearchByModel.Size = new System.Drawing.Size(408, 23);
            this.button_SearchByModel.TabIndex = 32;
            this.button_SearchByModel.Text = "Search";
            this.button_SearchByModel.UseVisualStyleBackColor = true;
            this.button_SearchByModel.Click += new System.EventHandler(this.button_SearchByModel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_OrderByYear);
            this.Controls.Add(this.button_OrderByPrice);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.dataGridView_Ads);
            this.Controls.Add(this.button_Close);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridView dataGridView_Ads;
        private System.Windows.Forms.PictureBox pictureBox_ViewPhoto;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_PreviousPicture;
        private System.Windows.Forms.Button button_NextPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Maxim;
        private System.Windows.Forms.TextBox textBox_Minim;
        private System.Windows.Forms.Button button_SearchByYear;
        private System.Windows.Forms.Button button_SearchByPrice;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_OrderByPrice;
        private System.Windows.Forms.Button button_OrderByYear;
        private System.Windows.Forms.TextBox textBox_ModelSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_SearchByModel;
        private System.Windows.Forms.Button button_OnlySellAds;
        private System.Windows.Forms.Button button_ShowRentAds;
    }
}