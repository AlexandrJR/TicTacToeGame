using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameField : Form
    {
        bool xPlayerTurn = false;
        int turnValue = 0;
        public GameField()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeCells();
        }

        private void InitializeGrid()
        {
            Grid.BackColor = Color.LightCoral;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
           
        }

        private void InitializeCells()
        {
            string labelName;
            for(int i=1; i<=9; i++)
            {
                labelName = "label" + i;
                Grid.Controls[labelName].Text = "";
                Grid.Controls[labelName].BackColor = Color.LightCoral;
            }
        }

        private void RestartGame()
        {
            InitializeGrid();
            InitializeCells();
            turnValue = 0;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (label.Text == string.Empty)
            {
                if (!xPlayerTurn)
                {
                    label.Text = "X";
                }
                else
                {
                    label.Text = "O";
                }
                xPlayerTurn = !xPlayerTurn;
                turnValue++;
            }
            WinCase();
            Draw();
        }

        private void WinCase()
        {
            if (
                    (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != String.Empty) ||
                    (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != String.Empty) ||
                    (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != String.Empty) ||
                    (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != String.Empty) ||
                    (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != String.Empty) ||
                    (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != String.Empty) ||
                    (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != String.Empty) ||
                    (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != String.Empty)
                )
            {
                GameOver();
            }
        }

        private void WinnerCellsChangeColor()
        {
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text != "")
            {
                ChangeCellsColor(label1, label2, label3, Color.Goldenrod);
            }

            else if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != "")
            {
                ChangeCellsColor(label4, label5, label6, Color.Goldenrod);
            }

            else if (label7.Text == label8.Text && label7.Text == label9.Text && label7.Text != "")
            {
                ChangeCellsColor(label7, label8, label9, Color.Goldenrod);
            }

            else if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != "")
            {
                ChangeCellsColor(label1, label4, label7, Color.Goldenrod);
            }

            else if (label2.Text == label5.Text && label2.Text == label8.Text && label2.Text != "")
            {
                ChangeCellsColor(label2, label5, label8, Color.Goldenrod);
            }

            else if (label3.Text == label6.Text && label3.Text == label9.Text && label3.Text != "")
            {
                ChangeCellsColor(label3, label6, label9, Color.Goldenrod);
            }

            else if (label1.Text == label5.Text && label1.Text == label9.Text && label1.Text != "")
            {
                ChangeCellsColor(label1, label5, label9, Color.Goldenrod);
            }

            else if (label3.Text == label5.Text && label3.Text == label7.Text && label3.Text != "")
            {
                ChangeCellsColor(label3, label5, label7, Color.Goldenrod);
            }

        }

        private void ChangeCellsColor(Label firstlabel, Label secondLable, Label thirdLabel, Color color)
        {
            firstlabel.BackColor = color;
            secondLable.BackColor = color;
            thirdLabel.BackColor = color;
        }

        private void GameOver()
        {
            WinnerCellsChangeColor();
            if (xPlayerTurn)
            {
                MessageBox.Show("X player won!");
            }
            else
            {
                MessageBox.Show("O player won!");
            }
            RestartGame();
        }

        private void Draw()
        {
            if(turnValue == 9)
            {
                MessageBox.Show("Draw!");
                RestartGame();
            }
        }
    }
}
