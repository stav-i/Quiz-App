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

namespace quizapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        SoundPlayer splayer = new SoundPlayer();

        //Play
        public void buttonPlay_Click(object sender, EventArgs e)
        {
            // Play nappi häviää ja Stop nappi tulee näkyviin
            SoundPlayer splayer = new SoundPlayer("harmaalokki.wav");
            splayer.Play();
            buttonPlay.Visible = false;
            buttonStop.Visible = true;
            
        }
        //Stop
        public void buttonStop_Click(object sender, EventArgs e)
        {
            //Stop nappi häviää painettaessa ja Play nappi tulee näkyviin

            splayer.Stop();
            buttonStop.Visible = false;
            buttonPlay.Visible = true;
            
        }

    }
}
