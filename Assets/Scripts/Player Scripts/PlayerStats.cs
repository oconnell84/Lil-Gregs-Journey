using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentXP;

    public int[] toLevelUp;

    public int strength = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (currentXP >= toLevelUp[currentLevel])
        {

            currentLevel++;
            strength++;

        }

	}

    public void AddExperience(int experienceToAdd)
    {

        currentXP += experienceToAdd;

    }
}
