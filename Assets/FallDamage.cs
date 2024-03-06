using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour {
	void Update () {
		// check controller height
		if (transform.position.y < -10) {
			// run self GameOver script
			GetComponent<GameOver>().GameOverSequence();

		}
	}
}
