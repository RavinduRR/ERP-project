using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderManaging
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.Write("Login");

            if (checkedListBox1.CheckedItems.Count == 0) // Check if no item is checked
            {
                MessageBox.Show("Please select at least one user type.");
            }
            else if (checkedListBox1.GetItemChecked(0)) // Check if the first item is selected
            {
                Admindashboard adminDashboardForm = new Admindashboard();
                adminDashboardForm.Show();
                this.Hide();
            }
            else if (checkedListBox1.GetItemChecked(1)) // Check if the second item is selected
            {
                Cashierdashboard cashierDashboardForm = new Cashierdashboard();
                cashierDashboardForm.Show();
                this.Hide();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            textBox3.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    }

