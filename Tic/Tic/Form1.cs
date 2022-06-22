using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    public partial class Form1 : Form
    {
        char who = 'o';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private bool checkforwin()
        {
            
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                    (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                    (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
            {
                return true;
            }
           
            return false;
        }

        private bool nextstep()
        {
            if (checkforwin())
            {
                MessageBox.Show(($"The winner is {who.ToString().ToUpper()} !!!"));
                tableLayoutPanel1.Enabled = false;
            }
            else if (movement == 8)
            {
                MessageBox.Show("Draw!");
            }
            return true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'o';
            movement = 0;
            button1.Enabled = true; button1.Text = ""; button1.BackColor = Color.White;
            button2.Enabled = true; button2.Text = ""; button2.BackColor = Color.White;
            button3.Enabled = true; button3.Text = ""; button3.BackColor = Color.White;
            button4.Enabled = true; button4.Text = ""; button4.BackColor = Color.White;
            button5.Enabled = true; button5.Text = ""; button5.BackColor = Color.White;
            button6.Enabled = true; button6.Text = ""; button6.BackColor = Color.White;
            button7.Enabled = true; button7.Text = ""; button7.BackColor = Color.White;
            button8.Enabled = true; button8.Text = ""; button8.BackColor = Color.White;
            button9.Enabled = true; button9.Text = ""; button9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is noughts and crosses.");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Orange;

            if(who == 'o')
            {
                bt.Text = "o";
                nextstep();
                who = 'x';
            }

            else if(who == 'x')
            {
                bt.Text = "x";
                nextstep();
                who = 'o';
            }
            movement++;

        }
    }
}
