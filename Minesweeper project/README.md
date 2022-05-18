# minesweeper-project


# Project: Minesweeper

## MVP

-   Recreate a simplified version of the game Minesweeper to be played in a C# console application
-   The game should be able to randomly generate 10 mines in a 10x10 grid
-   The user will be able to enter a command that represents a coordinate to check a location for a mine
-   The application will display a number from 0-8 depending on how many mines surround that location
-   If the user selects a mine, the game will respond "boom!" and the game will be lost
-   If every non-mine square has been revealed, the game is won

## Bonuses

-   Render a grid of 10x10 mines with numbers indicating checked spaces
-   Allow for the user to configure number of mines and grid size via a configuration.json file
-   (Difficult) Discovering an empty square should reveal all squares around it, and cascade into other nearby empty squares

-------
PLANNING THE PROJECT
- rendomly generate 10 mines into a 10 x 10 grid:
	- have an array of coordinates that are the grid. they are fixed
	- grid ( A1, A2, A3....B1, B2, B3 ...ETC)

	- an array that has a numbers and mines. 

	Q - how to keep the numbers and mines near each other so you know where the mines are?

	Q - would it be an array?

	- generate random number in an array with RANDOM.NEXT Method

	- you could have an empty array from 0 - 100 and fill it with the mines and the numbers

	- SHUFFLE METHOD??

	- Could do it with an object - the coordinates of the grid are the object with the numbers and mines an option within the object.

	- if coord touches a mine then number +1 for how many mines it touches? (0-8) or mine.

- create grid/array/object - where are you storing your mines and numbers?
- assign 10 mines
- assign numbers base don locaitn of the mine

Q - how does it know where hte mines are?

	- mines are random - the other numbers follow the mines

	MULTIMENTIONAL ARRAY? - create an array of 10 rows and 10 columsn.
	- fill muti dimensional arry randomly with mines.
	- fill array with numbers based on location of mines.


METHOD - that creates the grid - 

METHOD - that randomly generates 10 mines within grid.


