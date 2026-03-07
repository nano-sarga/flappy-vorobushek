# Flappy Vorobushek  ⋆｡ ﾟ☁︎｡ ⋆ 𓅪 ｡ ﾟ☀︎｡ ⋆｡ ﾟ

**Flappy Vorobushek** is a small arcade game inspired by the classic **Flappy Bird**, built with **Unity and C#**.

The player controls a **little sparrow doctor** flying through obstacles in a setting inspired by the atmosphere of the **Second World War era**.

The project was created as an experimental game to explore **Unity gameplay mechanics, physics systems, scene management, and pixel art workflows**.

All visual assets were created manually as **pixel art using Aseprite**.

https://github.com/user-attachments/assets/a435bb2f-f3a8-4fe6-975e-414678dcd00f

# Gameplay ⚔⊹ ࣪ ˖

The gameplay follows a classic arcade loop:

* Press **Space** to make the sparrow flap
* Avoid pipes and obstacles
* Pass through gaps to increase your score
* Try to beat your **best score**

When the player reaches **45 points**, the background music switches to a **victory-themed track**.


# Music System ˖ ݁♬⋆.˚𝄞

The game includes a simple music system connected to the menu.

Features:

* multiple menu tracks
* ability to change music by clicking the **radio in the menu**
* automatic switch to **victory music at 45 points**
* music persists between scenes

Music is controlled by a global **MusicManager**.


# Screenshots 📽

## Menu
<img width="1252" height="545" alt="flappy_menu" src="https://github.com/user-attachments/assets/77d74197-bf6c-46c6-a5dc-a818ac9b5aab" />

## Gameplay
<img width="1253" height="540" alt="flappy_game" src="https://github.com/user-attachments/assets/b6dd3911-68a7-4cf2-b1e1-7ef8f5ebfc99" />

## Game Over
<img width="1255" height="543" alt="flappy_over" src="https://github.com/user-attachments/assets/7708a540-1ca5-45ae-954d-816905714417" />


## Settings
<img width="1253" height="543" alt="flappy_settings" src="https://github.com/user-attachments/assets/9bd1aa93-51fc-4bf6-9ac6-da03777fb30e" />

# Technologies ⚛

* **Unity Engine**
* **C#**
* **Unity Physics (Rigidbody2D)**
* **Unity UI**
* **PlayerPrefs** for persistent data
* **WebGL build**
* **Aseprite** for pixel art

# Project Structure 🗂

```
Assets
│
├── Scripts
│   ├── birdScript.cs
│   ├── pipeSpawner.cs
│   ├── pipeScript.cs
│   ├── pipeMiddleScript.cs
│   ├── LogicScript.cs
│   ├── menuScript.cs
│   ├── settingScript.cs
│   ├── scoreScript.cs
│   ├── MusicManager.cs
│   ├── backScript.cs
│   └── cursorScript.cs
│
├── Scenes
│   ├── Menu
│   ├── Main Scene
│   └── Settings
│
├── Prefabs
│
└── Art
    └── Pixel sprites created in Aseprite
```

---

# Game Systems 🖥

## Bird Controller 𓅪

`birdScript.cs`

Handles:

* jumping mechanics
* Rigidbody physics
* collision detection
* out-of-bounds detection
* triggering game over

---

## Pipe Spawner ⸙

`pipeSpawner.cs`

Responsible for generating pipes during gameplay.

Features:

* spawns pipes periodically
* randomizes pipe height
* creates endless gameplay

---

## Pipe Movement ༄

`pipeScript.cs`

Moves pipes to the left and removes them when they leave the screen.

---

## Score System ✦

`pipeMiddleScript.cs`

Uses a trigger between pipes.

When the bird passes through the trigger:

```
logic.addScore(1)
```

The score increases.

---

## Game Manager 🛡

`LogicScript.cs`

Central game controller.

Responsibilities:

* updating score UI
* handling Game Over state
* restarting the scene
* switching music at 45 points
* navigating between scenes

---

## Music Manager ♬ˎˊ˗

`MusicManager.cs`

A global music system using the **Singleton pattern**.

Features:

* menu music playlist
* intense gameplay music
* track switching
* persistent music between scenes

---

## Best Score System ☆

`scoreScript.cs`

Uses **PlayerPrefs** to store the best score.

Example:

```
PlayerPrefs.SetInt("BestScore", score)
```

This allows the record to persist between game sessions.

---

## Background System ☘

`backScript.cs`

Creates a scrolling background effect.

Currently the background system works **imperfectly and may require improvement**.

# Controls 🖳

| Action          | Key   |
| --------------- | ----- |
| Flap            | Space |
| Menu Navigation | Mouse |

# Graphics ✎𓂃

All sprites and UI elements were created manually as **pixel art** using **Aseprite** and then imported into Unity.

Assets include:

* bird character
<img width="1970" height="1080" alt="flappy_bird" src="https://github.com/user-attachments/assets/cea8cff1-0e20-4a36-b160-2090408a50d5" />

* pipes and UI icons
<img width="1970" height="1080" alt="flappy_ui" src="https://github.com/user-attachments/assets/bebeb94b-4fe7-419e-be05-095cc5d82a43" />

* environment elements
<img width="1970" height="1080" alt="flappy_background" src="https://github.com/user-attachments/assets/9acfd37d-5d77-4657-b994-8a1dde3ae381" />

* menu visuals
<img width="1970" height="1080" alt="flappy_radio" src="https://github.com/user-attachments/assets/e0cd0524-a033-4124-a77f-7e96023819e1" />


# Future Improvements ⌯⌲

Some features that could be added in the future:

* wing animation for the bird
* victory scene (currently only music changes at 45 points)
* fix background scrolling behavior
* unlockable birds after reaching certain scores
* additional locations
* day and night cycle
* improved settings menu (volume, audio controls)
* mobile version of the game

# Author 모

Created by **Nori**

A small Unity project exploring:

* arcade gameplay mechanics
* pixel art creation
* game systems architecture
