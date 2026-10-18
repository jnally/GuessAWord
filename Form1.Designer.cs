namespace GuessAWord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHiddenWordDispl = new Label();
            lblHiddenWordDisplay = new Label();
            grpHidden = new GroupBox();
            grpGuess = new GroupBox();
            btnGuess = new Button();
            txtGuess = new TextBox();
            lblGuess = new Label();
            grpResult = new GroupBox();
            lblResultMessage = new Label();
            lblResult = new Label();
            grpNewGameQuit = new GroupBox();
            btnQuit = new Button();
            btnNewGame = new Button();
            grpHidden.SuspendLayout();
            grpGuess.SuspendLayout();
            grpResult.SuspendLayout();
            grpNewGameQuit.SuspendLayout();
            SuspendLayout();
            // 
            // lblHiddenWordDispl
            // 
            lblHiddenWordDispl.AutoSize = true;
            lblHiddenWordDispl.Font = new Font("Segoe UI", 20F);
            lblHiddenWordDispl.Location = new Point(0, 23);
            lblHiddenWordDispl.Name = "lblHiddenWordDispl";
            lblHiddenWordDispl.Size = new Size(228, 46);
            lblHiddenWordDispl.TabIndex = 0;
            lblHiddenWordDispl.Text = "Hidden Word:";
            // 
            // lblHiddenWordDisplay
            // 
            lblHiddenWordDisplay.AutoSize = true;
            lblHiddenWordDisplay.Font = new Font("Segoe UI", 20F);
            lblHiddenWordDisplay.Location = new Point(234, 23);
            lblHiddenWordDisplay.Name = "lblHiddenWordDisplay";
            lblHiddenWordDisplay.Size = new Size(90, 46);
            lblHiddenWordDisplay.TabIndex = 1;
            lblHiddenWordDisplay.Text = "*****";
            // 
            // grpHidden
            // 
            grpHidden.Controls.Add(lblHiddenWordDispl);
            grpHidden.Controls.Add(lblHiddenWordDisplay);
            grpHidden.Location = new Point(12, 12);
            grpHidden.Name = "grpHidden";
            grpHidden.Size = new Size(823, 93);
            grpHidden.TabIndex = 2;
            grpHidden.TabStop = false;
            // 
            // grpGuess
            // 
            grpGuess.Controls.Add(btnGuess);
            grpGuess.Controls.Add(txtGuess);
            grpGuess.Controls.Add(lblGuess);
            grpGuess.Location = new Point(246, 111);
            grpGuess.Name = "grpGuess";
            grpGuess.Size = new Size(407, 87);
            grpGuess.TabIndex = 3;
            grpGuess.TabStop = false;
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Segoe UI", 18F);
            btnGuess.Location = new Point(254, 23);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(128, 48);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Segoe UI", 18F);
            txtGuess.Location = new Point(195, 23);
            txtGuess.MaxLength = 1;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(53, 47);
            txtGuess.TabIndex = 1;
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Font = new Font("Segoe UI", 18F);
            lblGuess.Location = new Point(12, 23);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(177, 41);
            lblGuess.TabIndex = 0;
            lblGuess.Text = "Enter Letter:";
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblResultMessage);
            grpResult.Controls.Add(lblResult);
            grpResult.Location = new Point(12, 204);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(823, 77);
            grpResult.TabIndex = 4;
            grpResult.TabStop = false;
            // 
            // lblResultMessage
            // 
            lblResultMessage.AutoSize = true;
            lblResultMessage.Font = new Font("Segoe UI", 16F);
            lblResultMessage.Location = new Point(106, 23);
            lblResultMessage.Name = "lblResultMessage";
            lblResultMessage.Size = new Size(361, 37);
            lblResultMessage.TabIndex = 1;
            lblResultMessage.Text = "Enter a letter and click Guess.";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 16F);
            lblResult.Location = new Point(6, 23);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 37);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result:";
            // 
            // grpNewGameQuit
            // 
            grpNewGameQuit.Controls.Add(btnQuit);
            grpNewGameQuit.Controls.Add(btnNewGame);
            grpNewGameQuit.Location = new Point(315, 287);
            grpNewGameQuit.Name = "grpNewGameQuit";
            grpNewGameQuit.Size = new Size(250, 60);
            grpNewGameQuit.TabIndex = 5;
            grpNewGameQuit.TabStop = false;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(139, 25);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(6, 25);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // Form1
            // 
            AcceptButton = btnGuess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(grpNewGameQuit);
            Controls.Add(grpResult);
            Controls.Add(grpGuess);
            Controls.Add(grpHidden);
            Name = "Form1";
            Text = "Guess A Word";
            Load += Form1_Load;
            grpHidden.ResumeLayout(false);
            grpHidden.PerformLayout();
            grpGuess.ResumeLayout(false);
            grpGuess.PerformLayout();
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            grpNewGameQuit.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void LblGuess_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblHiddenWordDispl;
        private Label lblHiddenWordDisplay;
        private GroupBox grpHidden;
        private GroupBox grpGuess;
        private TextBox txtGuess;
        private Label lblGuess;
        private Button btnGuess;
        private GroupBox grpResult;
        private Label lblResult;
        private Label lblResultMessage;
        private GroupBox grpNewGameQuit;
        private Button btnQuit;
        private Button btnNewGame;
    }
}
