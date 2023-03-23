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

namespace App
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer, _soundPlayer2;
        private bool check;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            _soundPlayer = new SoundPlayer("zabson.wav");
            _soundPlayer2 = new SoundPlayer("karaoke.wav");

            check = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("zabson.wav");
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Zatrzymaj";
                _soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Puść";
                _soundPlayer.Stop();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("wedding.wav");

            if (checkBox2.Checked)
            {
                if (checkBox2.Text == "Zatrzymaj wszystko")
                {
                    _soundPlayer.Stop();
                    _soundPlayer2.Stop();
                    checkBox2.Text = "Puść";
                    
                    check = true;
                    checkBox2.Checked = false;
                }
                else { 
                checkBox2.Text = "Zatrzymaj (Adaś się żeni)";
                _soundPlayer.Play();
                    check = false;
                }
            }
            else
            {
                if (!check) { 
                checkBox2.Text = "Zatrzymaj wszystko";
                _soundPlayer.Stop();
                _soundPlayer2.Play();
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _soundPlayer = new SoundPlayer("jadymy na.wav");

            if (checkBox3.Checked)
            {
                checkBox3.Text = "Zatrzymaj";
                _soundPlayer.Play();
            }
            else
            {
                checkBox3.Text = "Puść";
                _soundPlayer.Stop();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1XtNRLBXuHbPBk0N_U0oa9O6kXFVAJkHA/view?usp=sharing");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/yabuszko");

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1XtNRLBXuHbPBk0N_U0oa9O6kXFVAJkHA/view?usp=sharing");
        }
    }
}
