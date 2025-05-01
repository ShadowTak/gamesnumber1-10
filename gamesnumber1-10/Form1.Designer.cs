namespace gamenumber
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCountLabel;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCorrectLabel;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnReset;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCountLabel = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCorrectLabel = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTitle.Text = "เกมทายเลข 1-10";

            // lblPrompt
            this.lblPrompt.Location = new System.Drawing.Point(30, 70);
            this.lblPrompt.Size = new System.Drawing.Size(100, 20);
            this.lblPrompt.Text = "ป้อนเลข 1-10:";

            // txtGuess
            this.txtGuess.Location = new System.Drawing.Point(140, 68);
            this.txtGuess.Size = new System.Drawing.Size(100, 23);

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(260, 68);
            this.btnCheck.Size = new System.Drawing.Size(80, 25);
            this.btnCheck.Text = "ทายเลข!";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(30, 110);
            this.lblResult.Size = new System.Drawing.Size(300, 23);
            this.lblResult.Text = "";

            // lblCountLabel
            this.lblCountLabel.Location = new System.Drawing.Point(30, 150);
            this.lblCountLabel.Size = new System.Drawing.Size(130, 20);
            this.lblCountLabel.Text = "จำนวนครั้งที่เล่น:";

            // lblCount
            this.lblCount.Location = new System.Drawing.Point(160, 150);
            this.lblCount.Size = new System.Drawing.Size(50, 20);
            this.lblCount.Text = "0";

            // lblCorrectLabel
            this.lblCorrectLabel.Location = new System.Drawing.Point(30, 180);
            this.lblCorrectLabel.Size = new System.Drawing.Size(130, 20);
            this.lblCorrectLabel.Text = "จำนวนครั้งที่ถูก:";

            // lblCorrect
            this.lblCorrect.Location = new System.Drawing.Point(160, 180);
            this.lblCorrect.Size = new System.Drawing.Size(50, 20);
            this.lblCorrect.Text = "0";

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(110, 220);
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.Text = "เริ่มใหม่";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

// Form1
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCountLabel);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCorrectLabel);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnReset);
            this.Text = "เกมทายเลข";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
