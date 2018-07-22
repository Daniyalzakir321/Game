using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHESS_G
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.button99.Visible = false;
            this.button100.Visible = false;

            this.Text = "Chess Titan's";
            this.MinimizeBox= false;
            this.MaximizeBox = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            this.button90.Visible = false;
            this.button88.Visible = true;
        }

      

        private void button89_Click(object sender, EventArgs e)
        {
            this.button89.Visible = false;
            this.button88.Visible = false;
        }

        

        private void button91_Click_1(object sender, EventArgs e)
        {
            this.button91.Visible = false;
            this.button94.Visible = false;
        }

      
        private void button87_Click(object sender, EventArgs e)
        {
            this.button88.Visible = true ;
            this.button96.Visible = false;
        }

        

        private void button92_Click(object sender, EventArgs e)
        {
            this.button94.Visible = true;
            this.button98.Visible = false;
        }

       

        private void button95_Click(object sender, EventArgs e)
        {
            this.button99.Visible = true;
            this.button100.Visible = true;
            
            
            this.button96.Visible = false;
           

            this.button98.Visible = true;
            this.button100.Visible = true;

        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void button96_Click(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }

       
       
        

      

      
        
    }
}
