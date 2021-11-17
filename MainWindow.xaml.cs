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

            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            //makes sure player 1 begins game
            mPlayer1Turn = true;

            //Gets contain, all childre(buttons) and iterates through them
            Container.Children.Cast<Button>().ToList().ForEach(button => 
            {   
                //clears all text from buttons
                button.Content = string.Empty;

                //defaults background color to white
                button.Background = Brushes.White;

                //defaults forground(mouseover) colour to blue
                button.Foreground = Brushes.Blue;
            });
        }


        /// <summary>
        /// Handles a new button click event
        /// </summary>
        /// <param name="sender"> Button was clicked </param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
