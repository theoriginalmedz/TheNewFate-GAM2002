using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoScript : MonoBehaviour {
    public bool chasing;
    public bool zapping = false;
    public float waitToZap;
    private float zapTime;
    private GameObject playerFinder;
   
    public GameObject zapBullet;
    public float zapSpeed;

    public Transform ufoLocation;

	// Use this for initialization
	void Start () {
        playerFinder = GameObject.FindGameObjectWithTag("Player"); //This is to find the player Tag


	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 targetPosition = playerFinder.transform.position;
        if (chasing)
        {
            

            targetPosition.y += 4f;
            targetPosition.x += 1f;
            transform.position = Vector2.Lerp(transform.position, targetPosition, 0.5f);
        }
        
        if (Vector2.Distance(targetPosition,transform.position)<1 && !zapping)
        {
            zapping = true;
            zapTime = Time.time + waitToZap;

        }

        if (zapping)
        {
            //play the sound of count down before zap
            if (Time.time >= zapTime)
            {
                //zap?
                zapping = false;
                //GameObject zapBulletPrefab = Instantiate(zapBullet, ufoLocation.position, Quaternion.identity);
                //change the ufolLocation.position to some use target position + something like in the movement above
                // targetPosition.y += 4f;
                 targetPosition.x += 5f;
                GameObject zapBulletPrefab = Instantiate(zapBullet, targetPosition, Quaternion.identity);
               // zapBulletPrefab.GetComponent<Rigidbody2D>().AddForce(Vector2.down *zapSpeed);

            }
        }

	}
}
