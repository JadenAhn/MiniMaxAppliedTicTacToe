using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMaxAppliedTicTacToe
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        const int BOARD_SIZE = 9;
        string[] board = new string[BOARD_SIZE];
        int playerIndex = 0;
        string[] player = { "O", "X" };
        int totalNumber = 0;
        double[] scoreIndex = new double[BOARD_SIZE];

        enum gamePhase
        {
            gameStart,
            gameOver
        }
        gamePhase phase = new gamePhase();

        void initialize()
        {
            playerIndex = 0;
            cBoxPlayer.SelectedIndex = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                board[i] = i.ToString();
            }

            //Find all button named "btn" + i and set the text to ""
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                Button btn = this.Controls.Find("btn" + i, false).FirstOrDefault() as Button;
                btn.Text = "";
            }

            phase = gamePhase.gameStart;
            if (playerIndex == 1)
            {
                //Here comes AI
                int aiMove = minimax(playerIndex);
                if (aiMove != -1)
                {
                    board[aiMove] = player[playerIndex];
                    Button btn = this.Controls.Find("btn" + aiMove, false).FirstOrDefault() as Button;
                    btn.Text = player[playerIndex];
                    playerIndex = 1 - playerIndex;
                }
            }

            //Find all button and set the text to ""
            //foreach (Button btn in this.Controls.OfType<Button>())
            //{
            //    btn.Text = "";
            //}
        }

        string[] availableCells(string[] currentBoard)
        {
            List<string> availableCellsList = new List<string>();
            for (int i = 0; i < currentBoard.Length; i++)
            {
                if (currentBoard[i] != "O" && currentBoard[i] != "X")
                {
                    availableCellsList.Add(i.ToString());
                }
            }
            string[] availableCellsArray = availableCellsList.ToArray();
            return availableCellsArray;
        }

        void startGame()
        {
            phase = gamePhase.gameStart;
            if (checkAI.Checked)
            {
                if (playerIndex == 1)
                {
                    //Here comes AI
                    int aiMove = minimax(playerIndex);
                    if (aiMove != -1)
                    {
                        board[aiMove] = player[playerIndex];
                        Button btn = this.Controls.Find("btn" + aiMove, false).FirstOrDefault() as Button;
                        btn.Text = player[playerIndex];
                        playerIndex = 1 - playerIndex;
                    }
                }
            }
        }

        bool gameOver(string[] board, string player)
        {
            if (board[0] == player && board[1] == player && board[2] == player ||
                board[3] == player && board[4] == player && board[5] == player ||
                board[6] == player && board[7] == player && board[8] == player ||
                board[0] == player && board[3] == player && board[6] == player ||
                board[1] == player && board[4] == player && board[7] == player ||
                board[2] == player && board[5] == player && board[8] == player ||
                board[0] == player && board[4] == player && board[8] == player ||
                board[2] == player && board[4] == player && board[6] == player
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int getMax(string[] availableCellsArray)
        {
            double max = scoreIndex[int.Parse(availableCellsArray[0])];
            int maxIndex = int.Parse(availableCellsArray[0]);
            for (int i = 1; i < availableCellsArray.Length; i++)
            {
                if (scoreIndex[int.Parse(availableCellsArray[i])] > max)
                {
                    max = scoreIndex[int.Parse(availableCellsArray[i])];
                    maxIndex = int.Parse(availableCellsArray[i]);
                }
            }
            return maxIndex;
        }

        int minimax(int currentPlayerIndex)
        {
            int bestMove = -1;
            string[] availableCellsArray = availableCells(board);

            //Check all possible permutaion
            List<string> permutation = new List<string>();
            bool[] flag = new bool[board.Length];
            
            //initialize scoreIndex with 0
            for (int i = 0; i < scoreIndex.Length; i++)
            {
                scoreIndex[i] = 0;
            }

            if (availableCellsArray.Length > 0)
            {
                //One more code to block diagonal move
                if (board[0] == player[1 - playerIndex] && board[8] == player[1 - playerIndex] ||
                    board[2] == player[1 - playerIndex] && board[6] == player[1 - playerIndex]
                    )
                {
                    for (int i = 1; i < board.Length; i = i + 2)
                    {
                        if (availableCellsArray.Contains(i.ToString()))
                        {
                            bestMove = i;
                        }
                        else
                        {
                            Permute(availableCellsArray, permutation, flag, 1 - currentPlayerIndex);
                            bestMove = getMax(availableCellsArray);
                        }
                    }
                }
                else
                {
                    Permute(availableCellsArray, permutation, flag, 1 - currentPlayerIndex);
                    bestMove = getMax(availableCellsArray);
                }
            }
            //if (availableCellsArray.Length > 0)
            //{
            //    Random rnd = new Random();
            //    bestMove = int.Parse(availableCellsArray[rnd.Next(0, availableCellsArray.Length)]);
            //}
            return bestMove;
        }


        void Permute(string[] availableCellsArray, List<string> permutation, bool[] flag, int currentPlayerIndex)
        {
            if (permutation.Count == availableCellsArray.Length)
            {

                string[] tempBoard = new string[BOARD_SIZE];
                
                //copy the whole current board to tempBoard
                for (int i = 0; i < BOARD_SIZE; i++)
                {
                    tempBoard[i] = board[i];
                }

                //Copy permutation to tempBoard
                for (int i = 0; i < availableCellsArray.Length; i++)
                {
                    tempBoard[int.Parse(permutation[i])] = player[currentPlayerIndex];
                    //If currrent player(AI) wins in this permutation, add 10 to the score of the first index of scoreIndex
                    if (gameOver(tempBoard, player[currentPlayerIndex]))
                    {
                        scoreIndex[int.Parse(permutation[i])] += 10;
                        return;
                    }
                    ////If another player(Player) wins in this permutation, subtract 10 from the score of the first index of scoreIndex
                    else if (gameOver(tempBoard, player[1 - currentPlayerIndex]))
                    {
                        scoreIndex[int.Parse(permutation[i])] -= 10;
                        return;
                    }
                    else
                    {
                        scoreIndex[int.Parse(permutation[i])] += 0;
                    }
                    currentPlayerIndex = 1 - currentPlayerIndex;
                }

                totalNumber++;
            }

            for (int i = 0; i < availableCellsArray.Length; i++)
            {
                //Skip if this flag is used
                if (flag[i]) continue;

                permutation.Add(availableCellsArray[i]);
                //Set the flag true when it is used
                flag[i] = true;

                Permute(availableCellsArray, permutation, flag, currentPlayerIndex);
                permutation.RemoveAt(permutation.Count - 1);
                flag[i] = false;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Button works only when the phase is gameStart
            if (phase != gamePhase.gameOver)
            {
                string btnName = (sender as Button).Name.Substring(3);
                int btnIndex = int.Parse(btnName);

                //Button works only when the button is not used by any players
                if (board[btnIndex] != player[0] && board[btnIndex] != player[1])
                {
                    (sender as Button).Text = player[playerIndex];
                    board[btnIndex] = player[playerIndex];

                    if (gameOver(board, player[playerIndex]))
                    {
                        MessageBox.Show("Player " + (playerIndex + 1) + " WIN!!");
                        phase = gamePhase.gameOver;
                        return;
                    }
                    else
                    {
                        if (availableCells(board).Length == 0)
                        {
                            MessageBox.Show("DRAW...");
                            phase = gamePhase.gameOver;
                            return;
                        }
                        else
                        {
                            playerIndex = 1 - playerIndex;
                            if (checkAI.Checked)
                            {
                                //Here comes AI
                                int aiMove = minimax(playerIndex);
                                if (aiMove != -1)
                                {
                                    board[aiMove] = player[playerIndex];
                                    Button btn = this.Controls.Find("btn" + aiMove, false).FirstOrDefault() as Button;
                                    btn.Text = player[playerIndex];
                                    if (gameOver(board, player[playerIndex]))
                                    {
                                        MessageBox.Show("Player " + (playerIndex + 1) + " WIN!!");
                                        phase = gamePhase.gameOver;
                                        return;
                                    }
                                    else
                                    {
                                        if (availableCells(board).Length == 0)
                                        {
                                            MessageBox.Show("DRAW...");
                                            phase = gamePhase.gameOver;
                                            return;
                                        }
                                    }
                                    playerIndex = 1 - playerIndex;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Board_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            initialize();
        }

        private void cBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerIndex = cBoxPlayer.SelectedIndex;
            startGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
