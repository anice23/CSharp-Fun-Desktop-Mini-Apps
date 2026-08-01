using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Solution_Tic_Tac_Tao_Game.Properties;

namespace _Solution_Tic_Tac_Tao_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enPlayer PlayerTurn = enPlayer.Player1;
        stGamesStatues GamesStatus;
        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            InProgress
        }
        struct stGamesStatues
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        public void EndGame()
        {
            labturn.Text = "GameOver";
            switch(GamesStatus.Winner)
            {
                case enWinner.Player1:
                    labres.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    labres.Text = "Player 2";
                    break;
                default:
                    labres.Text = "Draw";
                    break;

            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
        public bool CheckValues(Button btn1,Button btn2,Button btn3)
        {
            if(btn1.Tag.ToString()!="?"&&btn1.Tag.ToString()==btn2.Tag.ToString()&&btn1.Tag.ToString()==btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                if(btn1.Tag.ToString()=="X")
                {
                    GamesStatus.Winner = enWinner.Player1;
                    GamesStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {

                    GamesStatus.Winner = enWinner.Player2;
                    GamesStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GamesStatus.GameOver = false;
            return false;
        }
        public void CheckWinner()
        {
            //Check Rows

            //Row1
            if (CheckValues(button2, button3, button4))
                return;

            //Row2
            if (CheckValues(button5, button6, button7))
                return;

            //Row3
            if (CheckValues(button8, button9, button10))
                return;

            //CheckCols

            //Col 1 
            if (CheckValues(button2, button5, button8))
                return;
            if (CheckValues(button3, button6, button9))
                return;
            if (CheckValues(button4, button7, button10))
                return;


            //CheckDiag

            //Diag1
            if (CheckValues(button2, button6, button10))
                return;

            //Diag2
            if (CheckValues(button4, button6, button8))
                return;







        }
      public  void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        labturn.Text = "Player2";
                        GamesStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;



                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        labturn.Text = "Player1";
                        GamesStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if(GamesStatus.PlayCount==9)
            {
                GamesStatus.GameOver = true;
                GamesStatus.Winner = enWinner.Draw;
                EndGame();
            }
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      

       
        void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }
        void RestartGame()
        {

            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);
            RestButton(button10);


            PlayerTurn = enPlayer.Player1;
            labturn.Text = "Player 1";
            GamesStatus.PlayCount = 0;
            GamesStatus.GameOver = false;
            GamesStatus.Winner = enWinner.InProgress;
            labres.Text = "In Progress";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
    }
}
