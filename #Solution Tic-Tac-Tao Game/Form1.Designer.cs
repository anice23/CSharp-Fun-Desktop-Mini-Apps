namespace _Solution_Tic_Tac_Tao_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labturn = new System.Windows.Forms.Label();
            this.labres = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(58, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Winner";
            // 
            // labturn
            // 
            this.labturn.AutoSize = true;
            this.labturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labturn.Location = new System.Drawing.Point(58, 154);
            this.labturn.Name = "labturn";
            this.labturn.Size = new System.Drawing.Size(152, 42);
            this.labturn.TabIndex = 2;
            this.labturn.Text = "Player1";
            // 
            // labres
            // 
            this.labres.AutoSize = true;
            this.labres.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labres.Location = new System.Drawing.Point(58, 320);
            this.labres.Name = "labres";
            this.labres.Size = new System.Drawing.Size(224, 49);
            this.labres.TabIndex = 3;
            this.labres.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(36, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reastart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(469, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 75);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tic-Tac-Toe Game";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(425, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 157);
            this.button2.TabIndex = 6;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(668, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 147);
            this.button3.TabIndex = 7;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(904, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 147);
            this.button4.TabIndex = 8;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(425, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 137);
            this.button5.TabIndex = 9;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(668, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 145);
            this.button6.TabIndex = 10;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(904, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 145);
            this.button7.TabIndex = 11;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(425, 551);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 149);
            this.button8.TabIndex = 12;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(660, 558);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(187, 142);
            this.button9.TabIndex = 13;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Image = global::_Solution_Tic_Tac_Tao_Game.Properties.Resources.question_mark_96;
            this.button10.Location = new System.Drawing.Point(904, 558);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(179, 135);
            this.button10.TabIndex = 14;
            this.button10.Tag = "?";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1292, 724);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labres);
            this.Controls.Add(this.labturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labturn;
        private System.Windows.Forms.Label labres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

