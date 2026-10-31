using UnityEngine;

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

Debug.Log("Spark of Combat: Cyber Shield Activated!")

