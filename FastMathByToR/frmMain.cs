
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TORServices.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FastMathByToR
{
    public partial class frmMain : Form
    {
        private  ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       

        public frmMain()
        {
            InitializeComponent();
        }
        int score = 0, time = 90,t=60,count = 0;
        double Ans;
        string s = "";
        
        void GetProblems() {
            timer1.Stop();
            
            txtAns.Text = "";
            
            QuestionItem questionItem = Question.GetQuestion();
            Ans = questionItem.Ans;
            s = questionItem.QuestionString;
            count++;
            log.Debug("Problem:" + s);
            lblEq.Text = s;

             t = time;
            txtTime.Write(t);
            txtAns.Focus();
            timer1.Start();

        }
        void GetAns() {
            timer1.Stop();
            double inputValue;
            if (string.IsNullOrEmpty(lblEq.Text))
            {
                score++;
                MessageBox.Show("ได้คะแนนฟรี 1 คะแนน");
                lblStatus.Write($"ได้คะแนนฟรี 1 คะแนน");
                log.Debug($"ได้คะแนนฟรี 1 คะแนน");
            }
            else if (Double.TryParse(txtAns.Text.Trim(), out inputValue))
            {
                log.Debug($"GetAns:{Math.Round(inputValue, 2)} and {Math.Round(Ans, 2)}");
                if (Math.Round(inputValue, 2) == Math.Round(Ans, 2))
                {
                    score++;
                }
                else
                {
                    score--;
                }
            }
            else
            {
                score--;
                log.Debug("Invalid input. Please enter a valid number.");
               
            }
            
    
            lblStatus.Write($"คำตอบคือ {Math.Round(Ans, 2)}");
           
            txtScore.Text = score.ToString();
            lblStatus.Write($"โจทย์ {count} ข้อ คุณทำได้ {score} คะแนน");
            GetProblems();

;        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            log.Debug("Starting Application");
            lblStatus.Write("เริ่มต้นโปรแกรม");
            GetProblems();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Debug($"Closing Application Score = {score}");
            log.Debug("");
            log.Debug("");
            log.Debug("");
            log.Debug("");
        }


        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            log.Debug($"Score Change  to {score}");
        }


        private void txtAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) GetAns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAns();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            txtTime.Text = t.ToString();
            if (t <= 0)
            {   
                score--;
                txtScore.Text = score.ToString();
                GetProblems();
            }
        }

       
    }
}
