using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Vector3 startingPosition;
    public int coins = 0;
    public int acrobatics = 1;
    public double acrobaticsXP = 0;

    // Use this for initialization
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>(); // Get the rigidbody component
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.up = rb.velocity.normalized;



    }

    void FixedUpdate()
    {


        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      

        rb.velocity = targetVelocity * speed;



    }




    void OnTriggerEnter2D(Collider2D col)
    { // col is the trigger object we collided with
        if (col.tag == "Coin")
        {
            coins++;
            Destroy(col.gameObject); // remove the coin
            print("COIN DESTROYED");

        }

        else if (col.tag == "Spike")
        {
            print("SPIKE!");
            transform.position = startingPosition;


        }
    }
}
