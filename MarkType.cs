using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    /// <summary>
    /// The type of value a cell in the game is currently at
    /// </summary>
    public enum MarkType
    {
        /// <summary>
        /// The cell has not been click
        /// </summary>
        Free,
        /// <summary>
        /// The cell is a O
        /// </summary>
        Nought,
        /// <summary>
        /// The cells is an X
        /// </summary>
        Cross
    }
}
