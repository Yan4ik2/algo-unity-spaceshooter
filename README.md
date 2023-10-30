# Sample Unity 2D Vertical Scrolling Shooter Games

<p align='center'>
  <!---<img src="https://github.com/ajgquional/algo-unity-spaceshooter/blob/4533ee772d03ef8a455ddfe82d601633e10a7530/Algo-Unity-Vertical-Shooters-Cover.png" width=700 height=400/>--->
  <img src="https://github.com/ajgquional/algo-unity-spaceshooter/blob/4533ee772d03ef8a455ddfe82d601633e10a7530/Algo-Unity-Vertical-Shooters-Cover.png">
</p>

## About the games

A vertical scrolling shooter game is a popular variant of the shoot'em up genre - a sub-genre of the traditional shooter game. The games demonstrated here are samples created through Algorithmics' Unity Game Development Course, as part of the module on creating 2D games in Unity.

All three games demonstrated here have the same mechanics:
* The player, using a mouse and holding the left mouse button, has to control the player character anywhere on the game screen to avoid obstacles and to collect point items (stars, fuel tanks, or potions, depending on the specific game setting).
* The player character would automatically fire a projectile (thus, there's no need for the player to press a button to fire a projectile) at a specific time interval to destroy the obstacles.
* The objective is to earn as many points as the player can.
* When the player hits an obstacle, the game is over. 

The games just vary in the sprites used as well as the method to create the specific level design. This is to demonstrate that even though the game mechanics are the same, the game can still be made unique by applying a different design method. Specifically,
* The setting of the "Space Shooter Game" is based on the free placement of sprites (and the sprites used are relevant to the level set in space);
* The setting of the "Racing Shooter Game" is based on the work with layers of 2D and 3D objects (and the sprites used are cars and fuel tanks); and
* The setting of the "Zombie Shooter Game" is grid-based setting created through the use of sprite sheets and tilemaps (and the sprites used are robots, zombies, and potions).

The games are primarily created as an instructional material to teach 2D game development in Unity. The games can serve as a foundation for more complex game mechanics, such as the inclusion of additional levels, variation in the projectile used, etc.

The topic of gaming platforms is also discussed, in that the vertical scrolling shooter game is originally meant to be deployed in an Android phone. However, for demonstration purposes, the games are deployed to be playable in a web browser (as linked at the bottom of this README file). In this regard, further improvements/optimizations to the games for mobile gaming is considered (such as adding touch interfaces).

## About the repository and scripts

This repository contains all the scripts needed to complete the vertical scrolling shooter game in the module. The repository is divided into lesson folders containing the scripts used for that lesson. The folder names uses a naming scheme following the module number and the lesson number (for example, Module 1 Lesson 1 is written as "M1L1"). As a summary (and to aid in navigating this repository), the folder contains the following scripts:

* M5L2: Creating a space shooter. Part 1
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/GameController.cs">GameController.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Item.cs">Item.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Mover.cs">Mover.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Obstacle.cs">Obstacle.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Player.cs">Player.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Projectile.cs">Projectile.cs (version 1)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L2/Spawner.cs">Spawner.cs</a>

* M5L3: Creating a space shooter. Part 2
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/DontDestroyOnLoad.cs">DontDestroyOnLoad.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/Item.cs">Item.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/MainMenu.cs">MainMenu.cs</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/Obstacle.cs">Obstacle.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/Projectile.cs">Projectile.cs (version 2)</a>
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L3/UI.cs">UI.cs</a>

* M5L4: Working with a 2D environment. Game release
  * <a href="https://github.com/ajgquional/algo-unity-spaceshooter/blob/main/M5L4/Scrolling.cs">Scrolling.cs</a> 

> Note: This repository would be continuously updated as needed to include relevant informational materials (such as links for general resources as well as tutorials, when they're available), so be sure to check this repository from time-to-time.

## General instructions on using the scripts
1. Setup the game objects as discussed in the class or as detailed in the handbook.
2. Create the scripts, copy the programs from this repository, and paste them in the appropriately-created scripts.
3. Attach the scripts to the corresponding game objects.

### Special notes about the scripts:

> There are scripts which have multiple versions because the game is incrementally created within the lessons. Specifically, note that the following scripts have multiple versions: ```Item.cs```, ```Obstacle.cs```, and ```Projectile.cs```.

> The program contained in the scripts is highly annotated to serve as additional notes and guide for the student. Refer to the comments in the program to see what a particular line of code is meant to do.

> As a further aid on using the scripts, there are README files included within each folder in this repository. Refer to those files for additional guides.

## Published game links
* Space Shooter: https://algo-spaceshooter-adrian.netlify.app/
* Racing Shooter: https://algo-racingshooter-adrian.netlify.app/
* Zombie Shooter: https://algo-zombieshooter-adrian.netlify.app/
