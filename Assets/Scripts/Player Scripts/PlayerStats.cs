using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentXP;

    public int[] toLevelUp;


    public int[] HPLevels;
    public int[] attackLevels;
    public int[] defenceLevels;

    public int maxHP;
    public int currentAttack;
    public int currentDefence;

    public PlayerHealthManager PHM;


	// Use this for initialization
	void Start () {

        maxHP = HPLevels[1];
        currentAttack = attackLevels[1];
        currentDefence = defenceLevels[1];

	}
	
	// Update is called once per frame
	void Update () {
		
        if (currentXP >= toLevelUp[currentLevel])
        {

            currentLevel++;
            maxHP = HPLevels[currentLevel];
            currentAttack = attackLevels[currentLevel];
            currentDefence = defenceLevels[currentLevel];
            PHM.setMaxHP();

        }

	}

    public void AddExperience(int experienceToAdd)
    {

        currentXP += experienceToAdd;

    }
}
