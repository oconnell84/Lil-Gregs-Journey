using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;
    public PlayerHealthManager playerHealth;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        healthBar.maxValue = playerHealth.playerMaxHP;
        healthBar.value = playerHealth.playerCurrentHP;
        if (playerHealth.playerCurrentHP >= 0)
        {
            HPText.text = "HP: " + playerHealth.playerCurrentHP + "/" + playerHealth.playerMaxHP;
        }

        else
        {
            HPText.text = "HP: 0/" + playerHealth.playerMaxHP;

        }

	}
}
