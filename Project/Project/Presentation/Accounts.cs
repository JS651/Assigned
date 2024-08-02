using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Business_Logic;
using System.IO;

namespace Project.Presentation
{
    public partial class Accounts : Form
    {
        private DataHandler dataHandler = new DataHandler();
        private string selectedImagePath=null;

        public Accounts()
        {
            InitializeComponent();
        }

        private void AddOrUpdateStudent(bool isUpdate)
        {
            if (int.TryParse(StdNum.Text, out int id))
            {
                string name = stdname.Text;
                string surname = stdsname.Text;
                string dob = dobt.Text;
                string gender = gen.Text;
                string phone = Phone.Text;
                string address = Address.Text;
                string modulecode = mods.Text;
                string modulename = mods.Text;
                string moduledesc = desc.Text;
                string link = modlink.Text;

                byte[] imageData = ImageToByteArray(selectedImagePath);

                if (isUpdate)
                {
                    dataHandler.UpdateStudent(id, name, surname, dob, gender, phone, address, modulecode, modulename, moduledesc, link, imageData);
                    MessageBox.Show($"Student {id} has been updated successfully");
                }
                else
                {
                    dataHandler.InsertStudent(id, name, surname, dob, gender, phone, address, modulecode, modulename, moduledesc, link, imageData);
                    MessageBox.Show("Student Data Added Successfully");
                }
                // Reload data into dataGridView1
                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Invalid Student ID. Please enter a valid numeric ID.");
            }
        }
        private void LoadStudentData()
        {
            // Fetch data from the database and bind it to dataGridView1
            dataGridView1.DataSource = dataHandler.GetData("BC_Students");
        }
        // Helper method to convert Image to byte array
        private byte[] ImageToByteArray(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                // Handle the case where the imagePath is null, empty, or the file doesn't exist
                // You can throw an exception, return null, or handle it based on your requirements
                throw new ArgumentException("Invalid imagePath or file does not exist.", nameof(imagePath));
            }

            Image image = Image.FromFile(imagePath);

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void codes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddOrUpdateStudent(false);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddOrUpdateStudent(true);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(StdNum.Text, out int id))
            {
                dataHandler.DeleteData(id.ToString());
                MessageBox.Show("Student has been removed");
            }
            else
            {
                MessageBox.Show("Invalid Student ID. Please enter a valid numeric ID.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchText = search.Text;
            if (int.TryParse(StdNum.Text, out int id))
            {
                dataGridView1.DataSource = dataHandler.SearchStudent(id);
            }
            else
            {
                DataTable result = dataHandler.SearchStudentByName(searchText);
                dataGridView1.DataSource = result;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void StdNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Display the selected data in controls
                StdNum.Text = row.Cells["StudentID"].Value.ToString();
                stdname.Text = row.Cells["Name"].Value.ToString();
                stdsname.Text = row.Cells["Surname"].Value.ToString();
                dobt.Text = row.Cells["DOB"].Value.ToString();
                gen.Text = row.Cells["Gender"].Value.ToString();
                Phone.Text = row.Cells["Phone"].Value.ToString();
                Address.Text = row.Cells["Address"].Value.ToString();
                mods.Text = row.Cells["ModuleCode"].Value.ToString();
                codes.Text = row.Cells["Modulename"].Value.ToString();
                desc.Text = row.Cells["ModuleDesc"].Value.ToString();
                modlink.Text = row.Cells["Link"].Value.ToString();

                // Load the image from the database (assuming you have an "imagedata" column)
                byte[] imageData = (byte[])row.Cells["imagedata"].Value;
                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // If an image is selected, you can perform actions here
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Full image disp
                System.Diagnostics.Process.Start(selectedImagePath);
            }
            else
            {
                MessageBox.Show("Please select an image first.");
            }
        }

        private void mods_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void codes_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void gen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stdname_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dobt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void modlink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                // Display the selected image in pictureBox1
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
