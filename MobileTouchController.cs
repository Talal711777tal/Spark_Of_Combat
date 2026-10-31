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
private bool isTouching = falsevoid Update()

{

HandleTouchInput();

}

void HandleTouchInput()

{

if (Input.touchCount > 0)

{

Touch touch = Input.GetTouch(0);

if (touch.phase == TouchPhase.Began)

{

touchStartPosition = touch.position;

isTouching = true;

}

else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)

{

touchCurrentPosition = touch.position;

Vector2 direction = (touchCurrentPosition - touchStartPosition).normalized;

if (playerController != null)

{

playerController.Move(direction)}

}

else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)

{

isTouching = false;

if (playerController != null)

{

playerController.Move(Vector2.zero);

}

}

}

}

}

}

Tactical Combat UI (TacticalCombatUI.cs)

using UnityEngine;

using UnityEngine.UI;

namespace SparkOfCombat.Player

{

public class TacticalCombatUI : MonoBehaviour

[Header("References")]

public PlayerController playerController;

[Header("UI Buttons")]

public Button fireButton;

public Button shieldButton;

public Button captureButton;

void Start()

{

if (fireButton != null)

fireButton.onClick.AddListener(OnFireButtonPressed);

if (shieldButton != null)

shieldButton.onClick.AddListener(OnShieldButtonPressed);

if (captureButton != null)

captureButton.onClick.AddListener(OnCaptureButtonPressed);

}

void OnFireButtonPressed()

{

Debug.Log("Spark of Combat: Fire Action Triggered!");

}

void OnShieldButtonPressed()

{

Debug.Log("Spark of Combat: Cyber Shield Activated!")}

void OnCaptureButtonPressed()

{

Debug.Log("Spark of Combat: Tactical Capture Initiated!");

}

}

}

Camera Follow (CameraFollow.cs)

using UnityEngine;

namespace SparkOfCombat.Player

{

public class CameraFollow : MonoBehaviour

{

[Header("Target & Settings")]

public Transform target;

public float smoothSpeed = 0.125f;

public Vector3 offset = new Vector3(0f, 0f, -10f);

void LateUpdate()

{

if (target != null)

Vector3 desiredPosition = target.position + offset;

Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,

smoothSpeed);

transform.position = smoothedPosition;

}

}

}

}

Main Menu & Founder Credits (MainMenuManager.cs)

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

namespace SparkOfCombat.Core

{

public class MainMenuManager : MonoBehaviour

{

[Header("UI References")]

public Text titleText;

public Text founderText;

public Button playButton;

[Header("Settings")]

public string gameTitle = "Spark of Combat"public string founderName = "Talal";

public string gameplaySceneName = "GameScene";

void Start()

{

SetupUI();

if (playButton != null)

{

playButton.onClick.AddListener(StartGame);

}

}

void SetupUI()

{

if (titleText != null)

titleText.text = gameTitle;

if (founderText != null)

founderText.text = "Developed & Founded by: " + founderName;

}

public void StartGame()

{

Debug.Log("Starting Spark of Combat...");

SceneManager.LoadScene(gameplaySceneName);

}

}

3. Build & Deployment Checklist

1. Unity Project Setup: Company Name set to Talal, Product Name set to Spark of

Combat, Package Name configured as com.talal.sparkofcombat.

2. Scenes in Build:

- 0: MainMenu (Main Menu & Founder Credits)

- 1: GameScene (Tactical combat & player movement)

3. Android Export: Platform switched to Android, ready for generating the first APK file for

device testing
