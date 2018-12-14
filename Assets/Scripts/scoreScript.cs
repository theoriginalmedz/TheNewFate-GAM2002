using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

    public static int scoreValue = 0;
    Text Score;

	// Use this for initialization
	void Start () {
		Score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = "Score:" + scoreValue;
       // PlayerPrefs.SetFloat("Highscore", scoreValue); this is for the score being made
       //playerPrefs.GetFloat("Highscore") this is for referencing the made score
        
	}
}
