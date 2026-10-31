using UnityEngine;public string founderName = "Talal";

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

