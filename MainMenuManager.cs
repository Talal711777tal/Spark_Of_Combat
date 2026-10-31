using UnityEngine;

namespace SparkOfCombat.Player

{

public class MobileTouchController : MonoBehaviour

{

[Header("Settings")]

public PlayerController playerController;

private Vector2 touchStartPosition;

private Vector2 touchCurrentPosition;

private bool isTouching = false;
