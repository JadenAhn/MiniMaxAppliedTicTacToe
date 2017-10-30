namespace MiniMaxAppliedTicTacToe
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.cBoxPlayer = new System.Windows.Forms.ComboBox();
            this.checkAI = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(10, 13);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 95);
            this.btn0.TabIndex = 4;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(95, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 95);
            this.btn1.TabIndex = 5;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(180, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 95);
            this.btn2.TabIndex = 6;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(10, 115);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 95);
            this.btn3.TabIndex = 7;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(95, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 95);
            this.btn4.TabIndex = 8;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(180, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 95);
            this.btn5.TabIndex = 9;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(10, 217);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 95);
            this.btn6.TabIndex = 10;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(95, 217);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 95);
            this.btn7.TabIndex = 11;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(180, 217);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 95);
            this.btn8.TabIndex = 12;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(10, 358);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(110, 35);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "Restart";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cBoxPlayer
            // 
            this.cBoxPlayer.FormattingEnabled = true;
            this.cBoxPlayer.Items.AddRange(new object[] {
            "Player 1 (O)",
            "Player 2 (X)"});
            this.cBoxPlayer.Location = new System.Drawing.Point(70, 322);
            this.cBoxPlayer.Name = "cBoxPlayer";
            this.cBoxPlayer.Size = new System.Drawing.Size(92, 21);
            this.cBoxPlayer.TabIndex = 0;
            this.cBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.cBoxPlayer_SelectedIndexChanged);
            // 
            // checkAI
            // 
            this.checkAI.AutoSize = true;
            this.checkAI.Checked = true;
            this.checkAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAI.Location = new System.Drawing.Point(189, 325);
            this.checkAI.Name = "checkAI";
            this.checkAI.Size = new System.Drawing.Size(71, 17);
            this.checkAI.TabIndex = 1;
            this.checkAI.Text = "Versus AI";
            this.checkAI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Play As: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkAI);
            this.Controls.Add(this.cBoxPlayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Name = "Board";
            this.Text = "Unbeatable Tic Tac Toe";
            this.Load += new System.EventHandler(this.Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ComboBox cBoxPlayer;
        private System.Windows.Forms.CheckBox checkAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

