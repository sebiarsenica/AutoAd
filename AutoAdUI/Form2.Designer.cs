
namespace AutoAdUI
{
    partial class Form2
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_View = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.panel_Menu.Controls.Add(this.button_View);
            this.panel_Menu.Controls.Add(this.button_Add);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1095, 601);
            this.panel_Menu.TabIndex = 0;
            // 
            // button_View
            // 
            this.button_View.AutoSize = true;
            this.button_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.button_View.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_View.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_View.Location = new System.Drawing.Point(545, 0);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(550, 601);
            this.button_View.TabIndex = 1;
            this.button_View.Text = "View";
            this.button_View.UseVisualStyleBackColor = false;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Add.Location = new System.Drawing.Point(0, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(548, 601);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add ";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Form2";
            this.Text = "Auto Ads";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_Add;
    }
}