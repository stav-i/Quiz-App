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
        int questionNum = 0;
        //int totalQuestions = 3;
        int buttonTag;
        public Form1()
        {
            InitializeComponent();
            //label3.Text = TotalScore.ToString();

        }
       



        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Visible = false;
            //textBox2.Visible = false;
            //pictureBox1.Visible = true;
            //button1.Visible = false;
            //textBox3.Visible = false;
            //button7.Visible = true;
            //button6.Visible = true;
            //button2.Visible = true;
            //button3.Visible = true;
            //button4.Visible = true;
            //button5.Visible = true;
            //buttonShow.Visible = true;
            //pictureBox3.Visible = true;


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
            //label2.Visible = true;
            button7.Visible = true;
            button7.Enabled = true;
            TotalScore = 0;
            questionNum = 0;
            listIndex = 0;
            //label2.Text = "";
            //label3.Text = TotalScore.ToString();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

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
        private void buttonShow_Click(object sender, EventArgs e)
        {
            //pictureBox3.Visible = true;
            //pictureBox3.Image = Image.FromFile("Sarvipollo.jpg");
            //pictureBox3.Size = new Size(250, 200);
            //pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;



            //buttonShow.Visible = false;
            //buttonClose.Visible = true;

            pictureBox1.Visible = true;

            //button2.Visible = false;
            if (qRandomed[listIndex] == 1)
            {
                //CASE 1 Picture
                pictureBox1.Image = new Bitmap(@"grus2.jpg");
            }
            if (qRandomed[listIndex] == 2)
            {
                //CASE 2 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 3)
            {
                //CASE 3 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 4)
            {
                //CASE 4 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 5)
            {
                //CASE 5 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 6)
            {
                //CASE 6 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 7)
            {
                //CASE 7 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 8)
            {
                //CASE 8 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 9)
            {
                //CASE 9 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
            if (qRandomed[listIndex] == 10)
            {
                //CASE 10 Picture
                pictureBox1.Image = new Bitmap(@"grus.jpg");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            buttonShow.Visible = true;
            buttonClose.Visible = false;
        }






        //UUSI KOODI

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    //Random order to questions
        //    List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

        //    qRandomed = randomList.ToArray();

        //    questions(qRandomed[0]);
        //    button1.Visible = false;
        //    button2.Visible = true;
        //    button3.Visible = true;
        //    button4.Visible = true;
        //    button5.Visible = true;
        //    button6.Visible = true;
        //    button7.Visible = true;
        //    label2.Visible = true;
        //    button8.Visible = true;
        //    button8.Enabled = true;
        //    TotalScore = 0;
        //    questionNum = 0;
        //    listIndex = 0;
        //    label2.Text = "";
        //    label3.Text = TotalScore.ToString();
        //    button3.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;

        //}
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
            button6.Enabled = false;



            textBox1.Text = TotalScore.ToString();



        }
        private void questions(int i)
        {

            switch (i)
            {
                //QUESTIONS
                case 1:
                    
                    button3.Text = "Oikea";
                    button2.Text = "Toimii";
                    button4.Text = "Toimii";
                    button5.Text = "Toimii";

                    correctAnswer = 3; //= Button that has correct answer

                    break;

                case 2:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii2";
                    button2.Text = "Toimii2";
                    button4.Text = "Toimii2";
                    button5.Text = "Toimii2";

                    correctAnswer = 5;

                    break;

                case 3:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 4:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 5:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 6:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 7:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 8:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 9:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
                case 10:

                    pictureBox1.Visible = false;
                    button2.Visible = true;

                    button3.Text = "Toimii3";
                    button2.Text = "Toimii3";
                    button4.Text = "Toimii3";
                    button5.Text = "Toimii3";

                    correctAnswer = 6;

                    break;
            }

        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Visible = true;

        //    button2.Visible = false;
        //    if (qRandomed[listIndex] == 1)
        //    {
        //        //CASE 1 Picture
        //        pictureBox1.Image = new Bitmap(@"grus2.jpg");
        //    }
        //    if (qRandomed[listIndex] == 2)
        //    {
        //        //CASE 2 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 3)
        //    {
        //        //CASE 3 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 4)
        //    {
        //        //CASE 4 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 5)
        //    {
        //        //CASE 5 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 6)
        //    {
        //        //CASE 6 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 7)
        //    {
        //        //CASE 7 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 8)
        //    {
        //        //CASE 8 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 9)
        //    {
        //        //CASE 9 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //    if (qRandomed[listIndex] == 10)
        //    {
        //        //CASE 10 Picture
        //        pictureBox1.Image = new Bitmap(@"grus.jpg");
        //    }
        //}

        public void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button2.Visible = true;
            if (questionNum < (listIndex - 1))
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
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (qRandomed[listIndex] == 1)
            {
                //CASE 1 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Zoothera.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 2)
            {
                //Case 2 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 3)
            {
                //Case 3 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 4)
            {
                //Case 4 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 5)
            {
                //Case 5 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 6)
            {
                //Case 6 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 7)
            {
                //Case 7 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 8)
            {
                //Case 8 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 9)
            {
                //Case 9 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }
            else if (qRandomed[listIndex] == 10)
            {
                //Case 10 Bird Sound
                SoundPlayer Sounds = new SoundPlayer(@"Kurki.wav");
                Sounds.Play();
            }

        }




    }
    }

