using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAdUI
{
    public partial class Form2 : Form
    {
        internal static Form2 form2;
        
        public Form2()
        {
            InitializeComponent();
            form2 = this;
        }

        private Form activeForm = null;
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Menu.Controls.Add(childForm);
            panel_Menu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } //Open new form
        
        private void button_View_Click(object sender, EventArgs e)
        {
            button_Add.Visible = false;
            button_View.Visible = false;
            openChildForm(new Form3());
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            button_Add.Visible = false;
            button_View.Visible = false;
            openChildForm(new Form1());
        }

        public void ShowButtons()
        {
            button_Add.Visible = true;
            button_View.Visible = true;
        }
    }
}
