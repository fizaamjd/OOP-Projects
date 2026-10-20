# Console PacMan

Move with arrow keys through the original maze. The game tracks score and implements horizontal, vertical, random and pursuing ghost movement. Its loop uses a 90 ms delay and different ghost update frequencies.

Open `pacman/PacMan.sln` in Visual Studio, restore `packages.config` and build on Windows. `maze.txt` is copied to the output folder and must stay beside the executable. EZInput uses Windows key input, so this is not a browser game or a cross-platform console application.

The duplicate source folder named PacMan contains the same game with whitespace changes only. PacManGUI contains a solution without the actual GUI project and is not a second playable application.
