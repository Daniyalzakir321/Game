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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
            
          
                    this.Text="Chess Titan's";
                    this.MinimizeBox = false;
                    this.MaximizeBox = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}