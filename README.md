# FEUP-DDJD
Project for Digital Game Design and Development

Game Link: https://codyphin.itch.io/deadlinemeeter

# Deadline Meeter

## Game Description
Deadline Meeter is a casual game, where you impersonate a student at FEUP, trying to survive the semester. The goal is to collect as many ECTS as possible while avoiding obstacles and delivering your assignments by throwing them at the teachers. To help in this task, you can collect powerups that will increase your ability of delivering assignments.

The game is an endless side scroller that takes place in FEUP's B building and you can play as a male or a female character.

### Menus
The menu system is very simple. There is a main menu, from which the player can start the game, access audio settings, switch characters and access the leaderboard. The audio settings menu includes elements to control the game's audio, both music volume percentage and sound effects volume percentage. The leaderboard menu shows the top 5 scores and the names of the players who achieved those scores.

### Projectiles
The player can throw assignments, which work as simple projectiles, only moving horizontally. There is a cooldown to this mechanic, so that the player is not able to constantly throw assignments.
The other type of projectiles present in our game are the flying coffee projectiles. These are projectiles that appear after a random time interval and are malicious to the player (if they hit the player, the game is over). A warning sign appears at the location where the flying coffee projectile will spawn before it spawns, so that the player can plan his strategy accordingly.


### Teachers
The teachers spawn randomly and move in the direction of the player. Throwing an assignment at a teacher results in them becoming happy and giving the player 5 ECTS before fading away. If a teacher hits the player, the game is over. 
There are three types of teachers. The first one moves slowly, but in both directions (horizontally and vertically). The second one moves very fast, but only horizontally. Finally, the last type moves at a medium velocity, but follows the player (if the player moves up or down, the teacher will also move up or down).

### Collectibles
Collectibles are implemented in two ways: ECTS and powerups. ECTS spawn in various shapes and the player gets 1 score point for each collected ECTS. Powerups appear randomly during the game (there's a 10% chance of one appearing at every 50 meters) and can be of two types: the coffee powerup and the notes powerup. The coffee powerup allows the player to throw assignments at an infinite rate, removing the throwing cooldown. The notes powerup allows the player to throw assignments in groups of three, where one travels horizontally and the other two diagonally, in both directions of the y axis.

## Installing and playing
To play, you need to download it from this [link](https://github.com/diogohalmeida/FEUP-DDJD/releases/download/release1/DDJD-PP-GB1-DeadlineMeeter-game.zip). Then, simply extract the zip file and run 'DeadlineMeeter.exe'. The game should now boot up.

### Controls
The controls are very simple.

* Activate the "jetpack" to go up - **Spacebar**
* Throw assignment - **Z**
* Pause the game - **P**

## Highlights of the Development Process
One of the requirements for this project was that the NPCs should fire projectiles. We felt like this mechanic would not be a good addition to our game if implemented in the exact way it was meant to be implemented and, together with our teacher (Daniel Mendes), we reached the conclusion that this mechanic would be negative for the user experience of our game and, since we already had a similar mechanic (the flying coffee projectiles), we decided not to implement it.
The background of our game is not static: there are 8 variations of FEUP's B building's corridors included in our game and one is chosen randomly each iteration in runtime, making each gameplay different and unique.
Close to every game mechanic has sound effects associated. Those sound effects were found on YouTube, and adapted in order to fit the scenery of our game. Some of the sounds that are worth noticing: there are different "death" sounds for each type of death, a timed warning sound effect previous to the flying coffee spawning (which also has a sound effect for when it's thrown), different sound effects for each "phase" of the jetpack (one for running, one for going up and one for going down).

## Resources
All the sprites used in the game were created from scratch by Diogo Almeida, a member of our group. The sounds were downloaded from online sources, listed below:
* Main Menu Music: [https://youtu.be/Hvdfx9avekU](https://youtu.be/Hvdfx9avekU)
* Game Music: [https://youtu.be/l7SwiFWOQqM](https://youtu.be/l7SwiFWOQqM) and [https://youtu.be/PFbYfgStDQc](https://youtu.be/PFbYfgStDQc)
* Game Over Music: [https://youtu.be/DzFXGsRvSwA](https://youtu.be/DzFXGsRvSwA)

## Group Information
This game was developed by the group B1, composed by the following elements:
* Carlos Lousada - up201806302
* Diogo Almeida - up201806630
* Tomás Fontes - up201806252
