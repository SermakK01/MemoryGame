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
    public partial class MediumGame : Form
    {
        int tries = 0;
        int time = 0;

        List<PictureBox> icons_medium = new List<PictureBox>();
        private PictureBox[] pictureBoxes;

        List<int> Indexes = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,20,21,22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33,34,35,36,37,38,39,40,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,20,21,22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33,34,35,36,37,38,39,40,
        };

        PictureBox firstClicked = null, secondClicked = null;

        public MediumGame()
        {
            InitializeComponent();
        }

        private void MediumGame_Load(object sender, EventArgs e)
        {

        }

        //Code executed when the "START" is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxes = new PictureBox[80] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
            pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,pictureBox11,pictureBox12,pictureBox13,
            pictureBox14,pictureBox15,pictureBox16,pictureBox17,pictureBox18,pictureBox19,pictureBox20,pictureBox21,
            pictureBox22,pictureBox23,pictureBox24,pictureBox25, pictureBox26, pictureBox27,pictureBox28, pictureBox29, pictureBox30,
            pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35,pictureBox36,pictureBox37,pictureBox38,
            pictureBox39,pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45,
            pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,pictureBox51,pictureBox52,pictureBox53,
            pictureBox54,pictureBox55,pictureBox56,pictureBox57,pictureBox58,pictureBox59,pictureBox60,pictureBox61,
            pictureBox62,pictureBox63,pictureBox64,pictureBox65, pictureBox66, pictureBox67,pictureBox68, pictureBox69, pictureBox70,
            pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75,pictureBox76,pictureBox77,pictureBox78,
            pictureBox79,pictureBox80};



            DataContainer.Shuffle(Indexes);

            for (int i = 0; i < 80; i++)
            {
                pictureBoxes[i].ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/pic" + (Indexes[i]).ToString() + ".png";
                pictureBoxes[i].Tag = i;
            }
            label1.Text = "0";
            label2.Text = "0";

            timer1.Interval = 1000 * DataContainer.Time2;
            timer2.Interval = 1000 * DataContainer.Time1;

            timer2.Start();
        }

        private void CheckForWinner()
        {

            for (int i = 0; i < 80; ++i)
            {
                if (String.Equals(pictureBoxes[i].ImageLocation, "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/ReverseCard.png"))
                {
                    return;
                }
            }
            timer3.Enabled = false;
            MessageBox.Show("You matched all the icons! Congratulations you win!");
            Score score = new Score(tries.ToString(), time.ToString());
            score.ShowDialog();
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

            for (int i = 0; i < 80; i++)
            {
                pictureBoxes[i].ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/ReverseCard.png";
            }
            timer3.Enabled = true;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            PictureBox clickedLabel = sender as PictureBox;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ImageLocation != "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/ReverseCard.png")
            {
                return;
            }

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/pic" + (Indexes[(int)firstClicked.Tag]).ToString() + ".png";
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/pic" + (Indexes[(int)secondClicked.Tag]).ToString() + ".png";

            CheckForWinner();

            if (firstClicked.ImageLocation == secondClicked.ImageLocation)
            {
                firstClicked = null;
                secondClicked = null;
                tries += 1;
                label1.Text = tries.ToString();
            }
            else
            {
                tries += 1;
                label1.Text = tries.ToString();
                timer1.Start();
            }
                
        }

        private void Tries_click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = time.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/ReverseCard.png";
            secondClicked.ImageLocation = "C:/Users/kijpi/source/repos/MemoryGame/MemoryGame/Resources/ReverseCard.png";

            firstClicked = null;
            secondClicked = null;
        }
    }
}
