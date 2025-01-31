# 🐜Welcome to Ant Maze! 

This is a C# console game where you control an ant in its quest to return to its anthill through a challenging maze.

# 📃Description  
Ant Maze is a console-based maze simulation game where players control an ant with a specific ability and name, inspired by real-life ants, as they navigate through a randomly generated maze. The objective is to reach the anthill while avoiding obstacles and strategically utilizing the ant's unique ability. The intention of the game is to combine elements of strategy and exploration, leading players to think critically about their movements and decisions, as each choice can impact their journey through the maze.

# ✨Features
- **Randomly Generated Mazes**: Each playthrough offers you a different maze layout.
- **Ant Ability**: You can utilize a special ability from the ant you select to enhance your navigation and strategy through the maze.
- **Obstacle Avoidance**: Navigate through various obstacles that challenge your decision-making skills.
- **Exploration Elements**: Discover hidden paths and resources within the maze to reach the anthill.

**Please note that the game is still in development, and some features may not function as expected. ¡Your feedback is very valuable for improving the gameplay experience!**

# 🔍Classes and Methods Overview

### Ant Class
The `Ant` class represents the ant controlled by the player, including its properties and abilities. Each ant has a name, a unique skill, and coordinates in the maze. The class includes methods to use the ant's skill and manage cooldowns.

### Maze Class
The `Maze` class manages the maze structure and interactions. It initializes the maze, allows movement of the ant, and places barriers. The maze can be printed to the console to visualize the current state.

### Cell Class
The `Cell` class represents a single cell in the maze. It tracks whether the cell is an obstacle and whether it is hidden from view.

### Game Class
The `Game` class controls the overall game flow, including player turns and interactions. It initializes the maze and players, displays game information, and contains the main loop for gameplay.

This structure allows for strategic gameplay as players navigate their ants through the maze, utilizing unique skills to overcome obstacles and reach the anthill.

Please note that the game is still in development, and some features may not function as expected. Your feedback is valuable as we continue to improve the gameplay experience. Thank you for your understanding!


# ⚒️Technologies Used
This project was developed using the following technologies:
- C#
- .NET 8.0

# ▶️How to Get Started
To get started with the project, follow these steps:

1. Make sure you have .NET 8.0 installed.
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
