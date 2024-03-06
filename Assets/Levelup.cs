using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levelup : MonoBehaviour {

	public GameObject levelText;

	Text levelText_text;

	public static int level = 0;

	private void Start() {
		levelText_text = levelText.GetComponent<Text>();

		IncreaseLevel();
	}

	public void IncreaseLevel() {
		level++;

		// change level text
		levelText_text.text = "Level: " + level;
	}
}
