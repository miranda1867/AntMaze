# 🐜Welcome to Ant Maze! 
This is a C# console game where you control an ant in its quest to return to its anthill through a challenging maze.

# 📃Description  
Ant Maze is a console-based maze simulation game where players control an ant with a specific ability and name, inspired by real-life ants, as they navigate through a randomly generated maze. The objective is to reach the anthill while avoiding obstacles and strategically utilizing the ant's unique ability. The intention of the game is to combine elements of strategy and exploration, leading players to think critically about their movements and decisions, as each choice can impact their journey through the maze.

# ✨Features
- **Randomly Generated Mazes**: Each playthrough offers you a different maze layout.
- **Ant Ability**: You can utilize a special ability from the ant you select to enhance your navigation and strategy through the maze.
- **Obstacle Avoidance**: Navigate through various obstacles that challenge your decision-making skills.
- **Exploration Elements**: Discover hidden paths and resources within the maze to reach the anthill.

> ### [!Important] 
> Please note that the game is still in development, and some features may not function as expected. ¡Your feedback is very valuable for improving the gameplay experience!

# ⚒️Technologies Used
This project was developed using the following technologies:
- C#
- .NET 8.0

# 🎮How to Play Ant Maze

1. **Starting the Game**:
   - When you run the game, it initializes a 10x10 maze and displays it in the console.
   - Two players are created, each with their own ant.

2. **Game Controls**:
   - Use the following keys to control the movement of your ants:
     - **W**: Move Up
     - **A**: Move Left
     - **S**: Move Down
     - **D**: Move Right
     - **G**: Use the ant's ability

3. **Objective**:
   - Navigate your ant through the maze to reach the anthill while avoiding obstacles.
   - Use the unique abilities of your ant strategically to overcome challenges.

4. **Gameplay Loop**:
   - The game alternates turns between players.
   - On each turn, the current player can choose to use an ant's skill or move the ant in one of the four directions.
   - If the player chooses to move, the game checks if the new position is valid (not an obstacle).
   - After each move, the maze is printed to the console to visualize the current state.

5. **Using Ant Skills**:
   - Each ant has a unique skill that can be used during the player's turn.
   - Skills may include revealing parts of the maze, creating barriers, or other strategic advantages.
   - Skills have cooldowns, so players must manage their usage wisely.

6. **Winning the Game**:
   - The goal is to navigate through the maze effectively and reach the anthill.

# 🔍Classes and Methods Overview

### Program Class
The `Program` class serves as the entry point of the application, initializing the game and starting the gameplay loop.

### Ant Class
The `Ant` class represents the ant controlled by the player, including its properties and ability. Each ant has a name, a unique ability, and coordinates in the maze. The class includes methods to use the ant's ability and manage cooldowns.

### Maze Class
The `Maze` class manages the maze structure and interactions. It initializes the maze, allows movement of the ant, and places barriers. The maze can be printed to the console to visualize the current state.

### MazeGenerator Class
The `MazeGenerator` class is responsible for generating the maze using Prim's algorithm. It initializes the maze with walls and creates paths by randomly selecting walls and checking their neighboring cells. The class includes methods to generate the maze, check if a cell is part of the path, and add neighboring walls to the processing list.

### Cell Class
The `Cell` class represents a single cell in the maze. It tracks whether the cell is an obstacle and whether it is hidden from view.

### Player Class
The `Player` class represents a player in the game, managing their ant. It includes methods to add an ant and use its skill.

### GameManager Class
The `GameManager` class controls the overall game flow, including player turns and interactions. It initializes the maze and players, displays game information, and contains the main loop for gameplay.

# ▶️How to Get Started
To get started with the project, follow these steps:

1. First things first, make sure you have [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) installed.
2. Clone the repository:
```bash
git clone https://github.com/miranda1867/AntMaze.git
```
3. Open the terminal and navigate to the folder where you downloaded the game using the following command:
```bash
cd
```
4. Run the following command to start the game:
```bash
dotnet run
```
