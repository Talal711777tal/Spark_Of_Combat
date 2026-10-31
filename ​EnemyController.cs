using UnityEngine;

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

public string gameTitle = "Spark of Combat"
