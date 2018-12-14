using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoTrigger : MonoBehaviour {

    public GameObject ufoPrefab;
    public Transform spawnLocation;
    private GameObject spawnUFO;
    public float spawnSpeed;
    public float lifeTimer;
    private float originalTimer;
    public bool spawnIt;

	// Use this for initialization
	void Start () {
        originalTimer = lifeTimer;
	}
	
	// Update is called once per frame
	void Update () {
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            //spawnUFO.SetActive(false);
            Destroy(spawnUFO);
            
        }

        if (spawnIt)
        {
            SpawnUFO();
            spawnIt = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == ("Player"))
        {
            print("spawned");
            spawnIt = true;

        }
   
    }

    private void SpawnUFO()
    {
        spawnUFO = Instantiate(ufoPrefab, spawnLocation.position, Quaternion.identity);
        spawnUFO.GetComponent<Rigidbody2D>().AddForce(Vector2.down * spawnSpeed);
        lifeTimer = originalTimer;
        
    }
    
        
    
}
