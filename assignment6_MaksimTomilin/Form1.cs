using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace assignment6_MaksimTomilin
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int myChoice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            myChoice = 1;
            label1.Text = "Rock";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            myChoice = 2;
            label1.Text = "Paper";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            myChoice = 3;
            label1.Text = "Scissors";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int enemyChoice = random.Next(1, 4);
            showResult(enemyChoice, myChoice);
        }

        public void showResult(int enemyTurn, int myTurn)
        {
            if (enemyTurn == 1 && myTurn == 2)
            {
                label2.Text = "Paper wraps rock :D";
            }
            else if (enemyTurn == 2 && myTurn == 3)
            {
                label2.Text = "Scissors cuts paper :D";
            }
            else if (enemyTurn == 3 && myTurn == 1)
            {
                label2.Text = "Rock smashes scissors :D";
            }
            else if (enemyTurn == 2 && myTurn == 1)
            {
                label2.Text = "Paper wraps rock :(";
            }
            else if (enemyTurn == 3 && myTurn == 2)
            {
                label2.Text = "Scissors cuts paper :(";
            }
            else if (enemyTurn == 1 && myTurn == 3)
            {
                label2.Text = "Rock smashes scissors :(";
            }
            else
            {
                label2.Text = "Draw, play again";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
