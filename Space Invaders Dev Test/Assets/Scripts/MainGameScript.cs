using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour {

    private int score;
    

    [SerializeField]
    private GameObject PlayerPrefab;

    [SerializeField]
    private GameObject EnemyPrefab;
    

	// Use this for initialization
	void Start () {
        spawnPlayer();
        spawnEnemy(20);
        
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(count == 0)
        {
            spawnEnemy(20);
        }
	}

    void spawnPlayer()
    {
        Instantiate(PlayerPrefab);
    }

    void spawnEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if(i < 5)
            {
                Vector3 InstLoc = new Vector3(EnemyPrefab.transform.position.x + i, EnemyPrefab.transform.position.y);
                Instantiate(EnemyPrefab,InstLoc,EnemyPrefab.transform.rotation);
            }
            if (i < 10)
            {
                if (i >= 5)
                {
                    Vector3 InstLoc = new Vector3(EnemyPrefab.transform.position.x + (i-5), EnemyPrefab.transform.position.y-2);
                    Instantiate(EnemyPrefab, InstLoc, EnemyPrefab.transform.rotation);
                }
            }
            if (i < 15)
            {
                if (i >= 10)
                {
                    Vector3 InstLoc = new Vector3(EnemyPrefab.transform.position.x + (i-10), EnemyPrefab.transform.position.y - 4);
                    Instantiate(EnemyPrefab, InstLoc, EnemyPrefab.transform.rotation);
                }
            }
            if (i < 20)
            {
                if (i >= 15)
                {
                    Vector3 InstLoc = new Vector3(EnemyPrefab.transform.position.x + (i-15), EnemyPrefab.transform.position.y - 6);
                    Instantiate(EnemyPrefab, InstLoc, EnemyPrefab.transform.rotation);
                }
            }
        }
    }
}

/*
 * 
 * The Highscore tracking functionality is there just needs linking into the score system that would need finishing.
 * Also the unique feature was going to be a random powerup system including REVERSE which would have reversed the passage of the aliens.
 * There also would have been the ability to fire additional "bullets" at 45 degree angles. The influence for these unique additions are from the oldschool 2d space shooters.
 * The speed of both the player, the bullets and the enemies can all be adjusted with the speed variable in the properties tab of each prefab which will affect all entities created from those prefabs
 * Also the lives can be modified from the player properties
 * 
 * Lives is there and a lives check wouldn't take much longer to implement but the main delay for that would be getting the AI to fire back which again wouldn't take much longer but the "limit" was 2 hours thus stopping at this point.
 * The total number of plays is tracked at this time.
 * 
 * This is local based tracking.
 * 
 * To track this total plays and highscores across multiplayer my personal approach would be to utilise a small cloud based solution similar to the old style Unity Master Server. This would then push up a small update with a new possible highscore and another addition to the played count.
 * 
 * 
 * 
 */