using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ticTacToe
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members

        /// <summary>
        /// MarkType = variable name;
        /// Holds the current results of the cells in active game
        /// </summary>
        private MarkType[] mResults;
        /// <summary>
        /// True if player 1's turn (X) or player 2's turn (O)
        /// </summary>
        private bool mPlayer1Turn;
        /// <summary>
        /// True if the game has ended
        /// </summary>
        private bool mGameEnded;

        #endregion


        #region Constructor
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }
        #endregion

        private void NewGame()
        {
            //Create a new blank array of cells
            mResults = new MarkType[9];

            //For new game()
            //go through each result and explicitly sets each item free
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            //makes sure player 1 begins game
            mPlayer1Turn = true;

            //Gets container, all children(buttons) and iterates through them
            //using list fetches every button means we can use a for each
            Container.Children.Cast<Button>().ToList().ForEach(button => 
            {   
                //clears all text from buttons
                button.Content = string.Empty;

                //defaults background color to white
                button.Background = Brushes.White;

                //defaults forground(mouseover) colour to blue
                button.Foreground = Brushes.Blue;
            });

            //make sure game hasn't ended
            mGameEnded = false;
        }

        /// <summary>
        /// Handles a new button click event
        /// </summary>
        /// <param name="sender"> Button was clicked </param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            //gets button: sender can only be a button
            var button = (Button)sender;

            //finds the buttons in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            //Dont do anything if there is a value already
            if (mResults[index] != MarkType.Free)
                return;

            //set value to player turn
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;
        }
    }
}
