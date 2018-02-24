using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHP;
    public int playerCurrentHP;
    public PlayerStats playerStats;
    

	// Use this for initialization
	void Start () {

        playerMaxHP = playerStats.maxHP;
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

        int damageToGive = damage - playerStats.currentDefence;
        if (damageToGive <= 0)
        {

            damageToGive = 1;
        }

        playerCurrentHP -= damageToGive;



    }

    public void setMaxHP()
    {

        playerMaxHP = playerStats.maxHP; 

    }

    public void setHealthToMaxHP()
    {

        playerCurrentHP = playerMaxHP;

    }

    public void healFor(int amountToHeal)
    {

        playerCurrentHP += amountToHeal;

        if (playerCurrentHP > playerMaxHP)
        {

            playerCurrentHP = playerMaxHP;

        }

    }
}
