using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    public float movementSpeed;
    public float jumpingForce;

    public bool touchingGround;
    public LayerMask thisIsGround;

    private Collider2D Col;

    private Rigidbody2D rb2d;

    private Animator myAnim;

    public GameObject aliveUI, deathUI, cam, blood; 

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();

        Col = GetComponent<Collider2D>();

        myAnim = GetComponent<Animator>();

        aliveUI.SetActive(true);
        deathUI.SetActive(false);
        
       
    }
	
	// Update is called once per frame
	void Update () {
        touchingGround = Physics2D.IsTouchingLayers(Col, thisIsGround);

        rb2d.velocity = new Vector2(movementSpeed, rb2d.velocity.y);

        if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (touchingGround)
            {
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpingForce);
            }
        }

        myAnim.SetBool("Grounded", touchingGround);
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
      if (col.gameObject.tag.Equals("Death"))
        {
            aliveUI.SetActive(false);
            deathUI.SetActive(true);
            Instantiate(blood, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            
        }  
    }

}
