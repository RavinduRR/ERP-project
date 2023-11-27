using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodOrderManaging
{
    public partial class Userdetails : Form
    {
        public Userdetails()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fooddetails foodDetailsForm = new Fooddetails();
            foodDetailsForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Offerdetails offerDetailsForm = new Offerdetails();
            offerDetailsForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Managefood manageFoodForm = new Managefood();
            manageFoodForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Addfood addFoodForm = new Addfood();
            addFoodForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Manageoffers manageOfferForm = new Manageoffers();
            manageOfferForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admindashboard adminDashboardForm = new Admindashboard();
            adminDashboardForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Adduser addUserForm = new Adduser();
            addUserForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manageuser manageUserForm = new Manageuser();
            manageUserForm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Refresh(); // Reloading the form
            textBox1.Text = ""; // Clearing the values of all TextBoxes
            
            textBox3.Text = "";
            //...
        }
    }
}
