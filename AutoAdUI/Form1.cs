using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using AutoAd;
using static AutoAd.AutoAdClass;

namespace AutoAdUI
{
    public partial class Form1 : Form
    {
        public static AutoAdList Ads = new AutoAdList();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox() //Populate the comboBox 
        {
            foreach(var item in Enum.GetValues(typeof(AdType)))
            {
                comboBox_Type.Items.Add(item);
            }
        }

       

        private void button_AddPhoto_Click(object sender, EventArgs e) //Add photo to ad
        {
            
            var filePath = string.Empty; 

            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D://AutoAd/Anunturi";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                   filePath = openFileDialog.FileName;
            
            }
            
            if(!(string.IsNullOrEmpty(filePath)) )
                pictureBox_DIsplay.Image = new Bitmap(filePath);
            comboBox_Images.Items.Add(filePath);
            Ads.AddImagePath(filePath);
        }


        #region "Save ad"

        public bool AlreadySaved(string directoryName)
        {
            string[] dirs = Directory.GetDirectories(Global.filePath, directoryName);

            if (dirs.Length == 0)
                return false;
            else
                return true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (AlreadySaved(textBox_Id.Text) == true)  //Verify if ad is already saved
            {
                MessageBox.Show("Ad already saved");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Id cannot be empty!");
                return;
            }
            if (!(int.TryParse(textBox_Id.Text, out _)))
            {
                MessageBox.Show("Id needs to be a number");
                return;
            }
            
            if (string.IsNullOrEmpty(textBox_Brand.Text))
            {
                MessageBox.Show("Brand cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Model.Text))
            {
                MessageBox.Show("Model cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Price.Text))
            {
                MessageBox.Show("Price cannot be empty");
                return;
            }

            if (!(double.TryParse(textBox_Price.Text, out _)))
            {
                MessageBox.Show("Price needs to be a number");
                return;
            }

           if (string.IsNullOrEmpty(textBox_Year.Text))
            {
                MessageBox.Show("Year cannot be empty");
                return;
            }

            if (!(int.TryParse(textBox_Year.Text, out _)))
            {
                MessageBox.Show("Year needs to be a number");
                return;
            }
            
            if (string.IsNullOrEmpty(textBox_FuelType.Text))
            {
                MessageBox.Show("Fuel Type cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(richTextBox_Description.Text))
            {
                MessageBox.Show("Model cannot be empty");
                return;
            }

            if (comboBox_Type.SelectedIndex!=0 && comboBox_Type.SelectedIndex != 1)
            {
                MessageBox.Show("Ad type cannot be empty");
                return;
            }

            
            
            AutoAdClass ad = new AutoAdClass()
            {
                Id = int.Parse(textBox_Id.Text),
                Type = comboBox_Type.SelectedItem.ToString(),
                Brand = textBox_Brand.Text,
                Model = textBox_Model.Text,
                Price = double.Parse(textBox_Price.Text),
                Year = int.Parse(textBox_Year.Text),
                FuelType = textBox_FuelType.Text,
                Description = richTextBox_Description.Text,
            };

            Ads.Add(ad);


            string path = Path.Combine(Global.filePath, textBox_Id.Text);
            Directory.CreateDirectory(path);

            

            Ads.SaveOnDisk(path,ad);

            
        }

        #endregion

        private void button_NewAd_Click(object sender, EventArgs e)
        {
            Ads.DeleteImagesPath();
            textBox_Id.Clear();
            textBox_Brand.Clear();
            textBox_Model.Clear();
            textBox_Price.Clear();
            textBox_Year.Clear();
            textBox_FuelType.Clear();
            richTextBox_Description.Clear();
            comboBox_Type.SelectedIndex = 0;
            if (pictureBox_DIsplay!= null)
            {
                pictureBox_DIsplay.Dispose();
                pictureBox_DIsplay = null;
            }
        } //Delete textbox values

        private void button_Close_Click(object sender, EventArgs e)
        {
            Form2.form2.ShowButtons();
            Ads.DeleteImagesPath();
            textBox_Id.Clear();
            textBox_Brand.Clear();
            textBox_Model.Clear();
            textBox_Price.Clear();
            textBox_Year.Clear();
            textBox_FuelType.Clear();
            richTextBox_Description.Clear();
            comboBox_Type.SelectedIndex = 0;
            if (pictureBox_DIsplay != null)
            {
                pictureBox_DIsplay.Dispose();
                pictureBox_DIsplay = null;
            }
            this.Close();
            }//Closes the form

        private void comboBox_Images_SelectedIndexChanged(object sender, EventArgs e) //Display current image
        {
            pictureBox_DIsplay.Image = new Bitmap(comboBox_Images.SelectedItem.ToString());
        }

        private void button_Remove_Click(object sender, EventArgs e) //Remove an image before saving
        {
            if (comboBox_Images.SelectedIndex <= -1)
            { MessageBox.Show("You need to select an item first!"); return; }

            Ads.RemoveImage(comboBox_Images.SelectedItem.ToString());
            comboBox_Images.Items.Remove(comboBox_Images.SelectedItem);

            if (comboBox_Images.Items.Count > 0)
            {
                comboBox_Images.SelectedIndex = 0;
                pictureBox_DIsplay.Image = new Bitmap(comboBox_Images.SelectedItem.ToString());
            }
            else
                pictureBox_DIsplay.Image = null;
        }
    }
}
