using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;

namespace FastMathByToR
{
    public partial class Form1 : Form
    {
        public double Ans;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
        {
            for (int i = 1; i <= 200; i++)
            { 

                QuestionItem item = Question.GetQuestion();
                richTextBox1.WriteLine("Q:"+item.QuestionString + "\nAns:" + item.Ans + "\n");
                
                System.Threading.Thread.Sleep(500);
                this.Write(i);
            }
            this.Write("Complete");
        });
            
        }
    }
}
