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
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            Userdetails userDetailsForm = new Userdetails();
            userDetailsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admindashboard adminDashboardForm = new Admindashboard();
            adminDashboardForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manageuser manageUserForm = new Manageuser();
            manageUserForm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            textBox1.Clear();
            textBox2.Clear();
           
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            // Clear checked items from checkedListBox1
            checkedListBox1.ClearSelected();

            // Reload current page
            this.Refresh();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            textBox7.PasswordChar = '*';
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            textBox6.PasswordChar = '*';
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != textBox6.Text)
            {
                MessageBox.Show("The passwords you entered do not match. Please try again.");
                return;
            }

            // The passwords match
        }
    }
}
