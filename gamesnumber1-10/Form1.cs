using System;
using System.Windows.Forms;

namespace gamenumber
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int totalTries = 0;
        private int correctTries = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                if (userGuess < 1 || userGuess > 10)
                {
                    lblResult.Text = "กรุณากรอกเลขระหว่าง 1 ถึง 10";
                    return;
                }
                int randomNumber = random.Next(1, 11);
                totalTries++;
                if (userGuess == randomNumber)
                {
                    lblResult.Text = "ถูกต้อง! เลขคือ " + randomNumber;
                    correctTries++;
                }
                else
                {
                    lblResult.Text = "ผิด! เลขที่ถูกคือ " + randomNumber;
                }
                lblCount.Text = totalTries.ToString();
                lblCorrect.Text = correctTries.ToString();
            }
            else
            {
                lblResult.Text = "กรุณากรอกตัวเลขเท่านั้น";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGuess.Text = "";
            lblResult.Text = "";
            totalTries = 0;
            correctTries = 0;
            lblCount.Text = "0";
            lblCorrect.Text = "0";
        }

    }
}
