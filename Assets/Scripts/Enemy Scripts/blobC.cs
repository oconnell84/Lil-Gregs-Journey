using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobController: MonoBehaviour {

    public float moveSpeed;
    public int damage;

    private Rigidbody2D myRigidBody;

    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

    public float waitToReload;
    private bool reloading;
    private GameObject player;

	// Use this for initialization
	void Start () {

        myRigidBody = GetComponent<Rigidbody2D>();

       

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);

	}
	
	// Update is called once per frame
	void Update () {

        if (moving)
        {

            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;

            if (timeToMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = timeBetweenMove;

            }    

        }

        else
        {

            timeBetweenMoveCounter -= Time.deltaTime;

            // reset velocity to 0
            myRigidBody.velocity = Vector2.zero;
            if(timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = timeToMove;

                // randomize move direciton
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) *moveSpeed, 0f);


            }

        }

        if (reloading)
        {

            waitToReload -= Time.deltaTime;
            if (waitToReload < 0)
            {

                Application.LoadLevel(Application.loadedLevel);
                player.SetActive(true);


            }

        }
		
	}


    void OnCollisionEnter2D(Collision2D other)
    {

       /*
        * if(other.gameObject.name == "player_NEW")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            reloading = true;
            player = other.gameObject;

        }
        */

       

    }



}
