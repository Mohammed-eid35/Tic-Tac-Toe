using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    public partial class MainWindow : Window
    {

        // Private Members
        private CellType[ , ] grid;
        private bool player1Turn;
        private bool endGame;

        public MainWindow()
        {
            InitializeComponent();

            // Start a new game
            newGame();
        }

        private void newGame()
        {
            // Creat the 2D array and make it empty
            grid = new CellType[3, 3];
            for (int cRow = 0; cRow < 3; ++cRow)
                for (int cCol = 0; cCol < 3; ++cCol)
                    grid[cRow, cCol] = CellType.EmptyCell;

            // Make the first player start the game
            player1Turn = true;

            // Set default values to background, foreground and content
            container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;      // Empty Content
                button.Background = Brushes.White;  // Background Color
                button.Foreground = Brushes.Blue;   // Font Color
            });

            // The game hasn't finished yet
            endGame = false;
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            // If the game is finished
            if (endGame)
            {
                newGame();  // Start a new game
                return;
            }

            var button = (Button) sender; // Type Casting (sender) => (Button)
            
            // Getting the cell position
            var row = Grid.GetRow(button);      // The row number
            var col = Grid.GetColumn(button);   // The column number

            // If the cell is not empty don't mark it
            if (grid[row, col] != CellType.EmptyCell)
                return;

            // Mark the cell
            if (player1Turn) // Player1 = 'X'
            {
                grid[row, col] = CellType.XCell; // Make the grid = 'X'
                button.Content = "X";            // Change the content of the button to 'X'
            }
            else // Player2 = 'O"
            {
                grid[row, col] = CellType.OCell; // Make the grid = 'O'
                button.Content = "O";            // Change the content of the button to 'O'
            }

            if (!player1Turn) // Make the mark of the palyer2 red
                button.Foreground = Brushes.Red;

            // Changing the turn
            player1Turn = !player1Turn;

            // Check for a winner
            checkIfWinner();
        }

        private void checkIfWinner()
        {
            /// Rows
            // First Row
            if (grid[0, 0] != CellType.EmptyCell && (grid[0, 0] & grid[0, 1] & grid[0, 2]) == grid[0, 0])
            {
                endGame = true;

                btn00.Background = btn01.Background = btn02.Background = Brushes.Green;
            }

            // Second Row
            if (grid[1, 0] != CellType.EmptyCell && (grid[1, 0] & grid[1, 1] & grid[1, 2]) == grid[1, 0])
            {
                endGame = true;

                btn10.Background = btn11.Background = btn12.Background = Brushes.Green;
            }

            // Third Row
            if (grid[2, 0] != CellType.EmptyCell && (grid[2, 0] & grid[2, 1] & grid[2, 2]) == grid[2, 0])
            {
                endGame = true;

                btn20.Background = btn21.Background = btn22.Background = Brushes.Green;
            }

            /// Columns
            // First Column
            if (grid[0, 0] != CellType.EmptyCell && (grid[0, 0] & grid[1, 0] & grid[2, 0]) == grid[0, 0])
            {
                endGame = true;

                btn00.Background = btn10.Background = btn20.Background = Brushes.Green;
            }

            // Second Column
            if (grid[0, 1] != CellType.EmptyCell && (grid[0, 1] & grid[1, 1] & grid[2, 1]) == grid[0, 1])
            {
                endGame = true;

                btn01.Background = btn11.Background = btn21.Background = Brushes.Green;
            }

            // Third Column
            if (grid[0, 2] != CellType.EmptyCell && (grid[0, 2] & grid[1, 2] & grid[2, 2]) == grid[0, 2])
            {
                endGame = true;

                btn02.Background = btn12.Background = btn22.Background = Brushes.Green;
            }

            /// Diagonalas
            // First Diagonala
            if (grid[0, 0] != CellType.EmptyCell && (grid[0, 0] & grid[1, 1] & grid[2, 2]) == grid[0, 0])
            {
                endGame = true;

                btn00.Background = btn11.Background = btn22.Background = Brushes.Green;
            }

            // Second Diagonala
            if (grid[0, 2] != CellType.EmptyCell && (grid[0, 2] & grid[1, 1] & grid[2, 0]) == grid[0, 2])
            {
                endGame = true;

                btn02.Background = btn11.Background = btn20.Background = Brushes.Green;
            }

            /// NO WINNER !!
            bool emp = false;
            // Check if there empty cells
            foreach (var cl in grid)
                if (cl == CellType.EmptyCell)
                    emp = true;

            if (!emp) // If all cells not empty
            {
                // End the game
                endGame = true;

                // Make the backgroung of all cells orange
                container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }
        }
    }
}