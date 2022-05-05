using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace quizapp
{
    public partial class Form1 : Form
    {
        int[] qRandomed;
        int listIndex;
        int TotalScore = 0;
        int correctAnswer;
        int totalQuestions = 10;
        int buttonTag;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            qRandomed = randomList.ToArray();

            questions(qRandomed[0]);
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button7.Visible = true;
            button7.Enabled = true;
            TotalScore = 0;
            listIndex = 0;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            buttonShow.Visible = true;
            buttonClose.Visible = true;
            textBox3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Visible = false;
            button6.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            buttonShow.Visible = false;
            buttonClose.Visible = false;
        }
        
        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                TotalScore++;
            }
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = false;

        }
        private void questions(int i)
        {

            switch (i)
            {
                //QUESTIONS
                case 1:
                    //harakka

                    button3.Text = "Eurasian Magpie";
                    button2.Text = "Corn Crake";
                    button4.Text = "House Sparrow";
                    button5.Text = "European Herring Gull";

                    correctAnswer = 3; //= Button that has correct answer

                    break;

                case 2:
                    //Harmaalokki

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Great Tit";
                    button2.Text = "Eurasain Eagle-Owl";
                    button4.Text = "White's Thrush";
                    button5.Text = "European Herring Gull";

                    correctAnswer = 5;

                    break;

                case 3:
                    //Huuhkaja

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Corn Crake";
                    button2.Text = "Eurasian Magpie";
                    button4.Text = "Eurasian Eagla-Owl";
                    button5.Text = "Long-Eared Owl";

                    correctAnswer = 4;

                    break;
                case 4:
                    //Kirjorastas

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "White's Thrush";
                    button2.Text = "House Sparrow";
                    button4.Text = "Great Tit";
                    button5.Text = "Corn Crake";

                    correctAnswer = 3;

                    break;
                case 5:
                    //Kurki

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Black Woodpecker";
                    button2.Text = "Common Crane";
                    button4.Text = "Eurasian Magpie";
                    button5.Text = "European Herring Gull";

                    correctAnswer = 2;

                    break;
                case 6:
                    //Palokarki

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "European Herring Gull ";
                    button2.Text = "White's Thrush";
                    button4.Text = "Eurasian Eagle-Owl";
                    button5.Text = "Black Woodpecker";

                    correctAnswer = 5;

                    break;
                case 7:
                    //Ruisraakka

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Great Tit";
                    button2.Text = "Black Woodpecker";
                    button4.Text = "Corn Crake";
                    button5.Text = "House Sparrow";

                    correctAnswer = 4;

                    break;
                case 8:
                    //Sarvipollo

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Eurasian Magpie";
                    button2.Text = "Long-Eared Owl";
                    button4.Text = "Common Crane";
                    button5.Text = "European Herring Gull";

                    correctAnswer = 2;

                    break;
                case 9:
                    //Talitiainen

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Great Tit";
                    button2.Text = "Long-Eared Owl";
                    button4.Text = "House Sparrow";
                    button5.Text = "Black Woodpecker";

                    correctAnswer = 3;

                    break;
                case 10:
                    //Varpunen

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Corn Crake";
                    button2.Text = "Eurasian Eagle-Owl";
                    button4.Text = "House Sparrow";
                    button5.Text = "Long-Eared Owl";

                    correctAnswer = 4;

                    break;
            }

        }

        public void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer Sounds = new SoundPlayer();
            Sounds.Stop();
            pictureBox1.Visible = false;
            button2.Visible = true;
            pictureBox2.Visible = false;
            
            if (totalQuestions == (listIndex + 1))
            {
                button7.Enabled = false;

                textBox1.Text = "Game over, you got " + TotalScore + " points";
                TotalScore = 0;
                button1.Visible = true;
                button1.Text = "Start a new game?";
            }
            else
            {
                
                listIndex++;
                questions(qRandomed[listIndex]);

                button3.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void buttonShow_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;



            buttonShow.Visible = true;
            buttonClose.Visible = true;

            pictureBox2.Visible = true;

            if (qRandomed[listIndex] == 1)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"harakka.jpg");
            }
            if (qRandomed[listIndex] == 2)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Harmaalokki.jpg");
            }
            if (qRandomed[listIndex] == 3)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Huuhkaja.jpg");
            }
            if (qRandomed[listIndex] == 4)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Kirjorastas.jpg");
            }
            if (qRandomed[listIndex] == 5)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Kurki.jpg");
            }
            if (qRandomed[listIndex] == 6)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Palokarki.jpg");
            }
            if (qRandomed[listIndex] == 7)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Ruisraakka.jpg");
            }
            if (qRandomed[listIndex] == 8)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Sarvipollo.jpg");
            }
            if (qRandomed[listIndex] == 9)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Talitiainen.jpg");
            }
            if (qRandomed[listIndex] == 10)
            {
                pictureBox2.Size = new Size(350, 180);
                pictureBox2.Image = new Bitmap(@"Varpunen.jpg");
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            buttonShow.Visible = true;
            buttonClose.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (qRandomed[listIndex] == 1)
            {
                SoundPlayer Sounds = new SoundPlayer(@"harakka.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 2)
            {
                SoundPlayer Sounds = new SoundPlayer(@"harmaalokki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 3)
            {
                SoundPlayer Sounds = new SoundPlayer(@"huuhkaja.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 4)
            {
                SoundPlayer Sounds = new SoundPlayer(@"kirjorastas.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 5)
            {
                SoundPlayer Sounds = new SoundPlayer(@"kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 6)
            {
                SoundPlayer Sounds = new SoundPlayer(@"palokarki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 7)
            {
                SoundPlayer Sounds = new SoundPlayer(@"ruisraakka.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 8)
            {
                SoundPlayer Sounds = new SoundPlayer(@"sarvipollo.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 9)
            {
                SoundPlayer Sounds = new SoundPlayer(@"talitiainen.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 10)
            {
                SoundPlayer Sounds = new SoundPlayer(@"varpunen.wav");
                Sounds.Play();
            }
        }
    }
    }

