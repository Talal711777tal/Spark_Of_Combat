Spark of Combat - Project Documentation & Core

Scripts

1. Project Overview

- Game Title: Spark of Combat

- Founder & Developer: Talal

- Engine: Unity (Android Deployment Target)

- Identity: Developed and founded by Talal, featuring custom tactical controls and

branding.

2. Core Scripts & Architecture

Mobile Touch Controller (MobileTouchController.cs)

using UnityEngine;

namespace SparkOfCombat.Player

{

public class MobileTouchController : MonoBehaviour

{

[Header("Settings")]

public PlayerController playerController;

private Vector2 touchStartPosition;

private Vector2 touchCurrentPosition;

private bool isTouching = false
