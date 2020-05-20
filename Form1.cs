﻿using System;
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
        bool xplayerTurn = true;
        bool oplayerTurn = true;

        public GameField()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            Grid.BackColor = Color.LightCoral;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
        }

        private void Palyer_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Text = "X";
            if (xplayerTurn)
            {
                label.Text = "X";
            }
            else
            {
                label.Text = "O";
            }
            xplayerTurn = !xplayerTurn;
        }
    }
}
