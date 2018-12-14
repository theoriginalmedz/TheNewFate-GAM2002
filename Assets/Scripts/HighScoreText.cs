using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreText : MonoBehaviour {

    public Text myhighscore;

	// Use this for initialization
	void Start () {
        myhighscore.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //SceneManager.LoadScene("Endless Runner");
	}
}
