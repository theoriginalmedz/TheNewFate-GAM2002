using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour {

    public float enemyspeed;
    public float enemydistance;

    private bool rightMove = true;

    public Transform groundDetection;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * enemyspeed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, enemydistance);

        if (groundInfo.collider == false)
        {
            if (rightMove == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                rightMove = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                rightMove = true;
            }
        }
	}
}
