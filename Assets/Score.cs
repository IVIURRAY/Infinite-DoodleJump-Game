using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text highScore;
	
	// Update is called once per frame
	void Update () {
		highScore.text = "Score: " + player.position.y.ToString("0");
	}
}
