using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHSAnagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Word1_TextChanged(object sender, EventArgs e){

            button1.Visible = false;

            for (int i = 0; i < Word1.Text.Length; i++){
                
                if (Word1.Text[i] > 122 || Word1.Text[i] < 61){

                    Word1.ForeColor = Color.Red;
                    button1.Visible = false;

                }else{
                    Word1.ForeColor = Color.Green;
                }//end if
            }//end for

        }//end word1 text changed

        private void button1_Click(object sender, EventArgs e){

            Anagramer Check = new Anagramer();

            if (Check.AnagramCheck(Word1.Text, Word2.Text)){

                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.Green;
                textBox1.Text = "IT iS AN ANAGRAM!!";
                textBox1.Visible = true;

            }else{

                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.IndianRed;
                textBox1.Text = "NOT AN ANAGRAM";
                textBox1.Visible = true;

            }
            
        }//end button click

        private void Word2_TextChanged(object sender, EventArgs e){

            for (int i = 0; i < Word2.Text.Length; i++){
                
                if (Word2.Text[i] > 122 || Word2.Text[i] < 61){

                    Word2.ForeColor = Color.Red;
                    button1.Visible = false;

                }else{
                    Word2.ForeColor = Color.Green;
                    button1.Visible = true;
                }//end if
            }//end for

        }//end word2 text changed

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
