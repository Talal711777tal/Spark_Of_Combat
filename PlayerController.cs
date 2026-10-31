using UnityEngine;

}

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

