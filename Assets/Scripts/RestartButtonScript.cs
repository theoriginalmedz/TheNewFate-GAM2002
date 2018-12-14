using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void restartscene()
    {
        //save the score to something 
        //maybe player prefs hi score table?
        //maybe look at the google play tutorial from week 7

        scoreScript.scoreValue = 0;
        SceneManager.LoadScene("Endless Runner");
        

        
    }
}
