using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_damage : MonoBehaviour {

    public int damage;
    public GameObject damageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        

	}


    //
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {

            
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damage);

            // particle effect
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);

            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = damage;
            clone.transform.position = new Vector2(transform.position.x, transform.position.y);

        }

    }

}
