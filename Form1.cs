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
        public Form1()
        {
            InitializeComponent();
        }


        
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox1.Visible = true;
            button1.Visible = false;
            textBox3.Visible = false;
            button7.Visible = true;
            button6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            buttonShow.Visible = true;
            pictureBox3.Visible = true;
           
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
            pictureBox3.Visible = true;
            pictureBox3.Image = Image.FromFile("Sarvipollo.jpg");
            pictureBox3.Size = new Size(250, 200);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            

            buttonShow.Visible = false;
            buttonClose.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            buttonShow.Visible = true;
            buttonClose.Visible = false;
        }
    }
    }

