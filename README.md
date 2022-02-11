# ticTacToe

Learning WPF with a basic tictactoe game

//new game.

![new game](https://user-images.githubusercontent.com/72698786/153621220-3313acd7-d4f8-4898-b6b8-285532464d41.JPG) 

//Horizontal win

![horizontal wins](https://user-images.githubusercontent.com/72698786/153621231-c91f7506-6d1b-49a7-8297-7c27f48f4aad.JPG)

//Vertical win

![VerticalWin](https://user-images.githubusercontent.com/72698786/153621249-7d164a8b-953c-49e2-bfd2-d6213dce87e0.JPG)

//Diagonal win

![DiagonalWin](https://user-images.githubusercontent.com/72698786/153621262-ff99f37b-2925-4fd4-b3e4-52bebc9c0ef9.JPG)

//No win

![NoWin](https://user-images.githubusercontent.com/72698786/153621509-92c3d3dd-bf6a-4542-98f6-7081e7420bda.JPG)

//Created a basic shell to contain the tictactoe game

Concepts used:

First project in WPF():
    - Set buttons with grid row container and sectioned each with a gridRow.definition of "*".
    - this was to ensure each buttons equal on all sides.

Classes: 
  - MarkType: gets and sets the type of mark the player uses.
  - Learned enum: used to set markType for each player.
 
 Methods used:
 
  - For new game():
    - Checks to be sure game hasn't ended.
    - looped through through each result and explicitly sets each item free if not set that way already.
     
  - for buttonClick events():
    - Check if the game has ended: if true set newGame();
    - Marks player1 as the first player and sets their markType to "X", player2 markType "O";
    - sets colour of markType for each player;

  - for checkForWinner();
    - Checks for horizontal winner by comparing first and second button markTypes to the 0 button markType,
    - if they match this row win.
      -gameEnded = true;
    - If there are no winners: turns orange and starts new game.


-------------------------------------------------------------------
 - to do:
    - finish vertical and diagonal wins.
    -  is there a html, css, js version of this.
    -  Could I develop this for mobile and make a simple app?


