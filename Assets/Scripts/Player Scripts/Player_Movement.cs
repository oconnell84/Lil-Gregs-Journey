using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    Rigidbody2D rbody;
    Animator anim;


    public float speed = 1.0f;

    public bool attacking;
    public float attackTime;
    private float attackTimeCounter;



	// Use this for initialization
	void Start () {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


        if (!attacking)
        {

            Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            if (movement_vector != Vector2.zero)
            {

                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector.x);
                anim.SetFloat("input_y", movement_vector.y);
            }

            else
            {

                anim.SetBool("iswalking", false);

            }


            rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * speed);

            if (Input.GetKeyDown(KeyCode.F))
            {

                attackTimeCounter = attackTime;
                attacking = true;
                rbody.velocity = Vector2.zero;
                anim.SetBool("Attack", true);
            }
          

        }

        if(attackTimeCounter > 0)
        {

            attackTimeCounter -= Time.deltaTime;

        }

        else
        {

            attacking = false;
            anim.SetBool("Attack", false);
            attackTimeCounter = attackTime;

        }


	}

    
}
