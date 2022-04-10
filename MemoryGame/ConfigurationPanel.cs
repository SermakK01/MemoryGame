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
    public partial class ConfigurationPanel : Form
    {
        public ConfigurationPanel()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if ((bool)(comboBox2.SelectedItem == null))
            {
                MessageBox.Show("Please choose times");
            }
            else if ((bool)(comboBox3.SelectedItem == null))
            {
                MessageBox.Show("Please choose times");
            }
            else if (comboBox1.SelectedIndex == comboBox1.FindStringExact("Easy (48 cards)"))
            {
                DataContainer.Time1 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                DataContainer.Time2 = Convert.ToInt32(comboBox3.SelectedItem.ToString());
                DataContainer.easyGame.Show();
                DataContainer.configurationPanel.Close();
            }
            else if ((bool)(comboBox1.SelectedItem == "Medium (80 cards)"))
            {
                DataContainer.Time1 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                DataContainer.Time2 = Convert.ToInt32(comboBox3.SelectedItem.ToString());
                DataContainer.mediumGame.Show();
                DataContainer.configurationPanel.Close();
            }
            else if ((bool)(comboBox1.SelectedItem == "Hard (128 cards)"))
            {
                DataContainer.Time1 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                DataContainer.Time2 = Convert.ToInt32(comboBox3.SelectedItem.ToString());
                DataContainer.hardGame.Show();
                DataContainer.configurationPanel.Close();
            }
            else
            {
                MessageBox.Show("Please choose difficulty level");
            }

        }

        private void ConfigurationPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
