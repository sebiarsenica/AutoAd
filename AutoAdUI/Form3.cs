using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AutoAd;


namespace AutoAdUI
{
    public partial class Form3 : Form
    {
        public  AutoAdList Ads = new AutoAdList();
        public List<string> imagesList = new List<String>();
       
        public Form3()
        {
            InitializeComponent();
            Ads.LoadFromDisk(Global.filePath);
            button_PreviousPicture.Visible = false;
            button_NextPicture.Visible = false;
        }

       
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView_Ads.ReadOnly = true;
            var bindingList = new BindingList<AutoAdClass>(AutoAdList.Ads);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
            
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Form2.form2.ShowButtons();
            this.Close(); 

        }//Close current form

      

        private void button_Remove_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView_Ads.Rows.GetRowCount(DataGridViewElementStates.Selected); 
            if(selectedRowCount ==0)
            {
                MessageBox.Show("You need to select a row first!");
                return;
            }
            
            if(selectedRowCount > 1)
            {
                MessageBox.Show("You can only select one row at a time!");
                return;
            }

            
            int selectedrowindex = dataGridView_Ads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_Ads.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);


            pictureBox_ViewPhoto.Image.Dispose();
            pictureBox_ViewPhoto.Image = null;

            Ads.RemoveAd(cellValue, Global.filePath);
            dataGridView_Ads.Rows.RemoveAt(selectedrowindex);
            button_PreviousPicture.Visible = false;
            button_NextPicture.Visible = false;
            
        } //Remove Image 

        private void dataGridView_Ads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            imagesList.Clear();
            Ads.DeleteImagesPath();
            if (pictureBox_ViewPhoto.Image != null)
                pictureBox_ViewPhoto.Image.Dispose();
            
            Global.index = 0;
            int selectedrowindex = dataGridView_Ads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_Ads.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id"].Value);

            string dirpath = Path.Combine(Global.filePath, cellValue);
            DirectoryInfo dir = new DirectoryInfo(dirpath);
            FileInfo[] imageFiles = dir.GetFiles("*.jpg");
            if(imageFiles.Length==0)
            {
                MessageBox.Show("This ad has no images");
                return;
            }
            foreach (FileInfo f in imageFiles)
                imagesList.Add(Path.Combine(dirpath, f.Name));
            pictureBox_ViewPhoto.Image = new Bitmap(imagesList[Global.index]);
            button_PreviousPicture.Visible = false;
            if (imagesList.Count == 1)
            { button_NextPicture.Visible = false;
                
            }
            else
                if (imagesList.Count > 1)
                button_NextPicture.Visible = true;
        } //Load images for ad

        #region "Next and previous Picture"
        private void button_NextPicture_Click(object sender, EventArgs e) //Show next picture
        {
            
            Global.index++;
            if (Global.index == imagesList.Count - 1 )
                button_NextPicture.Visible = false;
            
            if (Global.index > 0)
                button_PreviousPicture.Visible = true;

            pictureBox_ViewPhoto.Image.Dispose();
            pictureBox_ViewPhoto.Image = new Bitmap(imagesList[Global.index]);
            
        }

        private void button_PreviousPicture_Click(object sender, EventArgs e) //Show previous picture
        {
            if (button_NextPicture.Visible == false)
                button_NextPicture.Visible = true;
            Global.index--;
            if (Global.index == 0)
                button_PreviousPicture.Visible = false;

            pictureBox_ViewPhoto.Image.Dispose();
            pictureBox_ViewPhoto.Image = new Bitmap(imagesList[Global.index]);
        }
        #endregion

        #region "Sort and order by"
        private void RefreshGrid()
        {
            dataGridView_Ads.Rows.Clear();
            Ads.LoadFromDisk(Global.filePath);
            var bindingList = new BindingList<AutoAdClass>(AutoAdList.Ads);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = null;
            dataGridView_Ads.DataSource = source;

            if (pictureBox_ViewPhoto.Image != null)
            {
                pictureBox_ViewPhoto.Image.Dispose();
                pictureBox_ViewPhoto.Image = null;
            }

            button_NextPicture.Visible = false;
            button_PreviousPicture.Visible = false;
        }


        private void button_SearchByPrice_Click(object sender, EventArgs e)
        {
            if(dataGridView_Ads.Rows.Count == 0)
            {
                MessageBox.Show("There are no ads"); return;
            }
            
            
            if (string.IsNullOrEmpty(textBox_Minim.Text))
            { MessageBox.Show("Minim cannot be empty!"); return;
            } 

            if(!(int.TryParse(textBox_Minim.Text, out _)))
            {
                MessageBox.Show("Minim needs to be a number!"); return;
            } 
            if(string.IsNullOrEmpty(textBox_Maxim.Text))
            {
                MessageBox.Show("Maxim cannot be empty!"); return; 
            } 
            if(!(int.TryParse(textBox_Maxim.Text, out _)))
            {
                MessageBox.Show("Maxim needs to be a number!"); return;
            }


            RefreshGrid();
            var list = Ads.PriceSort(double.Parse(textBox_Minim.Text), double.Parse(textBox_Maxim.Text));
            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;

        }

        private void button_SearchByYear_Click(object sender, EventArgs e)
        {
            if (dataGridView_Ads.Rows.Count == 0)
            {
                MessageBox.Show("There are no ads"); return;
            }

            if (string.IsNullOrEmpty(textBox_Minim.Text))
            {
                MessageBox.Show("Minim cannot be empty!"); return;
            }

            if (!(int.TryParse(textBox_Minim.Text, out _)))
            {
                MessageBox.Show("Minim needs to be a number!"); return;
            }
            if (string.IsNullOrEmpty(textBox_Maxim.Text))
            {
                MessageBox.Show("Maxim cannot be empty!"); return;
            }
            if (!(int.TryParse(textBox_Maxim.Text, out _)))
            {
                MessageBox.Show("Maxim needs to be a number!"); return;
            }

            RefreshGrid();
            var list = Ads.YearSort(double.Parse(textBox_Minim.Text), double.Parse(textBox_Maxim.Text));
            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;


        }

        private void button_OrderByPrice_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            var list = Ads.OrderByPrice();
            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
        }

        private void button_OrderByYear_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            var list = Ads.OrderByYear();
            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            textBox_Minim.Clear(); 
            textBox_Maxim.Clear();
            
        }

        private void button_SearchByModel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_ModelSearch.Text))
            {
                MessageBox.Show("You need to enter a model name first!"); return;
            }
            RefreshGrid();
            var list = Ads.SearchByModel(textBox_ModelSearch.Text);
            
            if(list.Count==0)
            {
                MessageBox.Show("There are no ads for that model"); return;
            }
            
            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
        }

        private void button_ShowRentAds_Click(object sender, EventArgs e)
        {

            RefreshGrid();
            var list = Ads.OnlyAds("Rent");

            if (list.Count == 0)
            {
                MessageBox.Show("There are no ads for that model"); return;
            }

            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
        }

        private void button_OnlySellAds_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            var list = Ads.OnlyAds("Sell");

            if (list.Count == 0)
            {
                MessageBox.Show("There are no ads for that model"); return;
            }

            dataGridView_Ads.Rows.Clear();
            var bindingList = new BindingList<AutoAdClass>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView_Ads.DataSource = source;
        }
        #endregion
    }
}
