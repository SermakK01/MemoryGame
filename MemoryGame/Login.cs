using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MemoryGame
{
    public partial class Login : Form
    {

        Regex letters_numbers;
        

        public Login()
        {
            InitializeComponent();
            letters_numbers = new Regex(@"^[a-zA-Z0-9]+$");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checks is the name correct
            if (letters_numbers.IsMatch(textBox1.Text))
            {
                DataContainer.Name = textBox1.Text;
                this.Hide();
                DataContainer.configurationPanel.Show();
                DataContainer.login.Close();

            }

            else
            {
                MessageBox.Show("Please enter correct Username!");

                textBox1.Text = "";
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
