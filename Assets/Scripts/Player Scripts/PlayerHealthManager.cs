using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHP;
    public int playerCurrentHP;

    // playerArmor isn't used, just an idea
    public int playerArmor;
    

	// Use this for initialization
	void Start () {

        playerCurrentHP = playerMaxHP;
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (playerCurrentHP < 0)
        {

            gameObject.SetActive(false);

        }

	}

    // enemy object can invoke this function to cause damage to player on collison
    public void HurtPlayer(int damage) {

        playerCurrentHP -= damage;



    }

    public void SetMaxHP()
    {

        playerCurrentHP = playerMaxHP; 

    }
}
