using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Score : Form
    {
        public Score(string tries, string time)
        {
            InitializeComponent();
            textBox1.Text = DataContainer.Name;
            textBox2.Text = tries;
            textBox3.Text = time;
            DataContainer.Tries_Final = int.Parse(tries);
            DataContainer.Time_Final = int.Parse(time);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Score_Load(object sender, EventArgs e)
        {

        }
    }
}
