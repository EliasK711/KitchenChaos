# 🍳 KitchenChaos — Production-Grade 3D Unity Simulation

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%2B%20LTS-black?style=flat&logo=unity)](https://unity.com/)
[![Render Pipeline](https://img.shields.io/badge/Render%20Pipeline-URP-blue?style=flat)](https://unity.com/srp/universal-render-pipeline)
[![Language](https://img.shields.io/badge/Language-C%23%209.0%2F10.0-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat)](LICENSE)

> A polished, fast-paced 3D culinary simulation game engineered in Unity & C#. Built with strong emphasis on production-ready software architecture, decoupled systems, clean code conventions, and modern Unity workflows based on [Code Monkey's Complete Unity Course](https://www.youtube.com/watch?v=AmGSEH7QcDg).

---

## 🎬 Gameplay & Mechanics Showcase

https://github.com/user-attachments/assets/db457496-d635-4121-8e9a-c175a6e255e3

---

## 🏗️ Technical Architecture & Design Patterns

The primary objective of this project is to apply robust, scalable software design patterns rather than relying on standard monolithic or tightly-coupled Unity scripts:

* **Event-Driven Architecture (Observer Pattern):** Decoupled communication across controllers using standard C# `System.Action` and `event` delegates, minimizing cyclic dependencies.
* **Separation of Concerns (MVC / Visual Separation):** Visual presentations, particle effects, and sound triggers remain completely segregated from core game simulation logic.
* **ScriptableObject-Driven Data Architecture:** Kitchen objects, recipes, slicing progressions, and audio clips utilize ScriptableObjects to decouple configuration data from runtime execution.
* **Contract-Based Design:** Usage of clear C# interfaces (e.g., `IKitchenObjectParent`) to enforce strict API boundaries between interactable world entities.
* **Finite State Machine (FSM):** Structured state tracking for cooking stations (Idle -> Frying -> Fried -> Burned) with strict timer transitions.
* **Modular Input System:** Migration to Unity's modern Event-based Input System (`com.unity.inputsystem`), supporting runtime rebinding and cross-platform readiness.

---

## 📐 Coding Conventions & Standards

This codebase strictly adheres to standard C# and Unity industrial naming conventions:
- **Private Fields:** `camelCase` prefixed with an underscore (e.g., `_moveSpeed`, `_playerAnimator`) or private serializable fields with `[SerializeField] private float moveSpeed;`.
- **Public Properties & Methods:** `PascalCase` (e.g., `public bool IsWalking()`).
- **Constants & Statics:** `PascalCase` or explicit static wrappers.
- **Explicit Scoping:** Explicit access modifiers declared on all classes, methods, and member variables.

---

## 🗺️ Roadmap & Lecture-Accurate Progress

Tracking milestone-by-milestone progress directly against the syllabus lectures:

### Phase 1: Core Systems & Locomotion
- [x] Project Initialization & URP Configuration
- [x] Coding Style, Architecture Conventions & Project Directory Setup
- [x] Asset Pipeline Setup & Volume-based Post-Processing
- [x] Player Movement Logic (Vector normalization & framerate-independent rotation)
- [x] Player Visuals & State-Driven Animator Setup (Walking/Idle transitions)
- [ ] Cinemachine Virtual Camera Integration
- [ ] New Input System Integration & Event-Driven Refactor
- [ ] Custom Physics Collision & Raycast Detection

### Phase 2: Interaction & Kitchen Objects
- [ ] Clear Counter Architecture & Interaction Interface
- [ ] C# Events for Interaction Triggers
- [ ] Selected Counter Visual Highlighting (Singleton Pattern)
- [ ] Kitchen Object Data Models via ScriptableObjects
- [ ] Object Pickup & Carry Handling via C# Interfaces (`IKitchenObjectParent`)
- [ ] Container Counter (Spawning Mechanics)
- [ ] Cutting Counter & Slicing Recipes (World Canvas Dynamic Progress Bars)
- [ ] Camera Billboard LookAt Utility
- [ ] Trash Counter (Object Lifecycle Destruction)

### Phase 3: Advanced Cooking Mechanics & Delivery
- [ ] Stove Counter FSM (Frying, Burning States & Timers)
- [ ] Plates Counter & Multi-Ingredient Plate Assembly Logic
- [ ] Delivery Counter & Recipe Matching Algorithm
- [ ] Custom Visual Enhancements via Shader Graph
- [ ] Dynamic Delivery Order UI Spawner

### Phase 4: Polish, Audio & Release
- [ ] Spatial Audio Engine & Sound Effects Manager
- [ ] Game State Loop (Countdown, Play State, Game Over State)
- [ ] Interactive Menus (Pause Screen, Options & Key Rebinding System)

---

## ⚙️ Getting Started & Local Development

### Prerequisites
* **Unity:** `2022.3 LTS` (or newer)
* **IDE:** Visual Studio Code / Visual Studio Community / JetBrains Rider

### Installation
1. Clone the repository:
   ```bash
   git clone [https://github.com/EliasK711/KitchenChaos.git](https://github.com/EliasK711/KitchenChaos.git)
