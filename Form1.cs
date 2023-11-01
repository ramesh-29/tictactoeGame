using System;
using System.Reflection;

namespace Tic_Tac_Toe_Game_WIn_Loss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WhoToPlay();
        }

        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        int player2WinCount = 0;

        bool playing2 = false;
        List<Button> buttons;

        
        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                if (checkConditionCheckGame())
                {
                    CheckGame();
                    CPUTimer.Stop();
                }
                else
                {
                    if (button5.Text == "?")
                    {
                        button5.Text = "O";
                        button5.BackColor = Color.DarkSalmon;
                        buttons.Remove(button5);
                        CheckGame();
                        CPUTimer.Stop();

                    }
                    else
                    {
                        int index = random.Next(buttons.Count);
                        buttons[index].Enabled = false;
                        currentPlayer = Player.O;
                        buttons[index].Text = currentPlayer.ToString();
                        buttons[index].BackColor = Color.DarkSalmon;
                        buttons.RemoveAt(index);
                        CheckGame();
                        CPUTimer.Stop();
                    }
                }
            }

        }

        private int countX(object sender1,object sender2,object sender3)
        {
            var button1 = (Button)sender1;
            var button2 = (Button)sender2;
            var button3 = (Button)sender3;
            int count = 0;
            int count2 = 0;
            if (button1.Text == "O") count2++;
            if (button2.Text == "O") count2++;
            if (button3.Text == "O") count2++;
            if (button1.Text == "X") count++;
            if (button2.Text == "X") count++;
            if (button3.Text == "X") count++;

            if (count == 0 && count2 == 2)
            {
                if (button1.Text == "?")
                {
                    currentPlayer = Player.O;
                    button1.Text = currentPlayer.ToString();
                    button1.BackColor = Color.DarkSalmon;
                    buttons.Remove(button1);
                    return count2;
                }
                if (button2.Text == "?")
                {
                    currentPlayer = Player.O;
                    button2.Text = currentPlayer.ToString();
                    button2.BackColor = Color.DarkSalmon;
                    buttons.Remove(button2);
                    return count2;
                }
                if (button3.Text == "?")
                {
                    currentPlayer = Player.O;
                    button3.Text = currentPlayer.ToString();
                    button3.BackColor = Color.DarkSalmon;
                    buttons.Remove(button3);
                    return count2;
                }
                
            }



            if (count == 2 && count2==0)
            {
                if (button1.Text == "?")
                {
                    currentPlayer = Player.O;
                    button1.Text = currentPlayer.ToString();
                    button1.BackColor = Color.DarkSalmon;
                    buttons.Remove(button1);
                    return count;
                }
                if (button2.Text == "?")
                {
                    currentPlayer = Player.O;
                    button2.Text = currentPlayer.ToString();
                    button2.BackColor = Color.DarkSalmon;
                    buttons.Remove(button2);
                    return count;
                }
                if (button3.Text == "?")
                {
                    currentPlayer = Player.O;
                    button3.Text = currentPlayer.ToString();
                    button3.BackColor = Color.DarkSalmon;
                    buttons.Remove(button3);
                    return count;
                }
            }
            return 0;
        }
        private bool checkConditionCheckGame()
        {
            if(countX(button1, button2, button3) == 2)
            {
                return true;
            }
            if (countX(button4, button5, button6) == 2)
            {
                return true;
            }
            if (countX(button7, button8, button9) == 2)
            {
                return true;
            }


            if (countX(button1, button4, button7) == 2)
            {
                return true;
            }
            if (countX(button2, button5, button8) == 2)
            {
                    return true;
            }
            if (countX(button3, button6, button9) == 2)
            {
                return true;
            }


            if (countX(button1, button5, button9) == 2)
            {
                return true;
            }
            if (countX(button3, button5, button7) == 2)
            {
                return true;
            }




            return false;
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (playing2 == true)
            {
                if (buttons.Count % 2 == 0)
                {
                    var button = (Button)sender;
                    currentPlayer = Player.O;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.DarkSalmon;
                    buttons.Remove(button);
                    CheckGame();
                }
                else
                {
                    var button = (Button)sender;
                    currentPlayer = Player.X;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.Cyan;
                    buttons.Remove(button);
                    CheckGame();
                }
            }
            else
            {
                var button = (Button)sender;
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                buttons.Remove(button);
                if (buttons.Count != 0) CPUTimer.Start();
                CheckGame();
            }





        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
              || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
              || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
              || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
              || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
              || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
              || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
              || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins", "MOO Says");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();
                return;
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                if (playing2)
                {
                    MessageBox.Show("Player2 Wins", "MOO Says");
                    player2WinCount++;
                    label2.Text = "Player2 Wins: " + player2WinCount;
                    RestartGame();
                    return;
                }
                else
                {
                    CPUTimer.Stop();
                    MessageBox.Show("CPU Wins", "MOO Says");
                    CPUWinCount++;
                    label2.Text = "CPU Wins: " + CPUWinCount;
                    RestartGame();
                    return;
                }
            }
            if (buttons.Count == 0)
            {
                MessageBox.Show("Match Draw", "MOO Says");
                RestartGame();
                return;
            }
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;
            }
        }

        private void ResetGame_Click(object sender, EventArgs e)
        {
            playing2 = false;
            GameStarted.Enabled = true;
            GameStarted.Text = "Start Game";
            playerWinCount = 0;
            CPUWinCount = 0;
            player2WinCount = 0;
            CPUTimer.Stop();
            label1.Text = "Players Wins: 0";
            label2.Text = "CPU Wins: 0";
            WhoToPlay();
        }
        private void WhoToPlay()
        {
            //  StartGame.Text = "Start Game";
            PlayWithCPU.Enabled = true;
            TwoPlayerGame.Enabled = true;
            List<Button> buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = false;
                button.Text = "?";
                button.BackColor = DefaultBackColor;
            }

        }
        private void PlayWithCPU_Click(object sender, EventArgs e)
        {
            PlayWithCPU.BackColor = Color.Green;
            TwoPlayerGame.BackColor = Color.Gray;
            label2.Text = "CPU Wins: 0";
            playing2 = false;
        }

        private void TwoPlayerGame_Click(object sender, EventArgs e)
        {
            playing2 = true;
            PlayWithCPU.BackColor = Color.Gray;
            TwoPlayerGame.BackColor = Color.Green;
            label2.Text = "Player2 Wins: 0";

        }

        private void StartGame_Click(object sender, EventArgs e)
        {

            StartTheGame();
            StartGame.Text = "Started";
        }
        private void StartTheGame()
        {
            TwoPlayerGame.Enabled = false;
            PlayWithCPU.Enabled = false;
            GameStarted.Enabled = false;
            RestartGame();
        }

        private void GameStarted_Click(object sender, EventArgs e)
        {
            GameStarted.Text = "Started";
            StartTheGame();
        }
    }
}