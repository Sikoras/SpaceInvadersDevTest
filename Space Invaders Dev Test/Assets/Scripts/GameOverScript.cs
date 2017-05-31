using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    private GameObject GameManager;

    // Use this for initialization
    void Start () {
        GameManager = GameObject.FindGameObjectWithTag("GameController");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAgain()
    {
        Application.LoadLevel(2);
    }

    public void MainMenu()
    {
        Application.LoadLevel(1);
    }

    public void EndGame()
    {
        GameManager.GetComponent<LoaderScript>().EndGameFunction();
    }


}
