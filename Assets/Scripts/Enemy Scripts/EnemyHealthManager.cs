using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyMaxHP;
    public int enemyCurrentHP;

    // enemyArmor isn't used, just an idea
    public int enemyArmor;


    // Use this for initialization
    void Start()
    {

        enemyCurrentHP = enemyMaxHP;

    }

    // Update is called once per frame
    void Update()
    {

        if (enemyCurrentHP < 0)
        {
            // if the enemy does not have health, DESTROY IT. easy enough Joey?
            Destroy(gameObject);

        }

    }

    // player object can invoke this function to cause damage on collision
    public void HurtEnemy(int damage)
    {

        enemyCurrentHP -= damage;
        Debug.Log("enemy HP: " +enemyCurrentHP);


    }


    // sets health to max
    public void SetMaxHP()
    {

        enemyCurrentHP = enemyMaxHP;

    }
}
