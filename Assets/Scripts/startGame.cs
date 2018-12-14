using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startscene()
    {
        //SceneManager.LoadScene("Endless Runner");
        SceneManager.LoadScene(Random.Range(2, 4));
        //Application.LoadLevel(Random.Range(1, 4))
    }
}
