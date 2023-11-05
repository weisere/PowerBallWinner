namespace PowerBallWinner
{
    partial class PowerBall
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
            NumberDisplay = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            checkWinnerBut = new Button();
            SuspendLayout();
            // 
            // NumberDisplay
            // 
            NumberDisplay.Location = new Point(24, 21);
            NumberDisplay.Margin = new Padding(3, 2, 3, 2);
            NumberDisplay.Name = "NumberDisplay";
            NumberDisplay.Size = new Size(875, 200);
            NumberDisplay.TabIndex = 0;
            NumberDisplay.Paint += panel1_Paint_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(23, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(23, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(23, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(23, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(23, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(230, 275);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(23, 23);
            textBox6.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 236);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 7;
            label1.Text = "Enter Numbers Below";
            // 
            // checkWinnerBut
            // 
            checkWinnerBut.Location = new Point(230, 232);
            checkWinnerBut.Name = "checkWinnerBut";
            checkWinnerBut.Size = new Size(162, 23);
            checkWinnerBut.TabIndex = 8;
            checkWinnerBut.Text = "CHECK YOUR NUMBERS";
            checkWinnerBut.UseVisualStyleBackColor = true;
            checkWinnerBut.Click += checkWinnerBut_Click;
            // 
            // PowerBall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 634);
            Controls.Add(checkWinnerBut);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(NumberDisplay);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PowerBall";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NumberDisplay;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Button checkWinnerBut;
    }
}