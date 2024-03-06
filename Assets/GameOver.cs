using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public void GameOverSequence() {
		// destroy whisper object, load game over scene
		Destroy(GameObject.Find("WhisperSource"));
		SceneManager.LoadScene("GameOver");
	}
}
