# ticTacToe

Learning WPF with a basic tictactoe game

![new game](https://user-images.githubusercontent.com/72698786/153617435-eae7c491-382a-4d94-aad7-15a57a0caec3.JPG)

![horizontal wins](https://user-images.githubusercontent.com/72698786/153617452-27b40bdb-3bf5-48e0-b91b-5030fd446c11.JPG)


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


