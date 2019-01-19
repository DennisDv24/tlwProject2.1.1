using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour{

	private TextMeshProUGUI textMesh;
	private int score;

		void Start(){
			textMesh = GetComponent<TextMeshProUGUI>();
			score = 0;
		}
		void Update(){
			textMesh.text = score.ToString();
			score++;
		}
}
