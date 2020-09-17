using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int value = 0;
	public Text score;
	public Text win;
	private int max_score = Bricks.tilesDown * Bricks.tilesAcross;

  void Start() {}

  void Update() {
    score.text = $"Score: {value}";
    if (value == max_score) win.text = "YOU WIN!";
  }
}
