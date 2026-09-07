# DoodleDuel

A browser-based turn-based strategy game built with **Blazor WebAssembly**.

DoodleDuel is a small game project focused on experimenting with interactive UI, component communication, coordinate systems, DOM-based collision detection, and browser-side state management.

## Demo
<p align="left"><img src="https://github.com/user-attachments/assets/d03b333b-39a9-4331-9a4a-f766138d3dd3" alt="DoodleDuel Gameplay" width="320"> </p>

## Features

* Turn-based gameplay between player and opponent
* Randomly generated units
* Click-based shooting system
* Percentage-based coordinate system for responsive positioning
* Separate shot state for each battlefield
* Mirrored shots between player and opponent fields
* DOM-based unit hit detection using JavaScript interop
* Unit hit and destruction states
* Player and opponent score tracking
* Turn indicator
* Game-over detection
* Restart and replay functionality
* Custom aiming cursor
* Configurable unit count
* Multiple battlefield backgrounds
* Settings persistence using browser `localStorage`
* Animated UI elements and game-over modal

## Architecture

The project is built around reusable Blazor components.

```text
BattleBoard
├── TurnIndicator
├── ScoreElement
├── OpponentField
│   ├── UnitElement
│   └── ShotElement
└── PlayerField
    ├── UnitElement
    └── ShotElement
```

`BattleBoard` manages the overall game state, while each field manages its own units and shots.

## Technologies

* C#
* .NET
* Blazor WebAssembly
* Razor Components
* JavaScript Interop
* HTML / CSS
* Browser `localStorage`

## Project Goals

DoodleDuel is primarily an experimentation project. The goal is to explore how a game-like interactive experience can be built using Blazor while keeping the UI componentized and the game logic relatively simple.
