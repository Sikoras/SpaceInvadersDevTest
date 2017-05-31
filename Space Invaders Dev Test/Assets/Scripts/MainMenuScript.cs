using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    private GameObject GameManager;

    [SerializeField]
    private Text Score1;

    [SerializeField]
    private Text Score2;

    [SerializeField]
    private Text Score3;

    [SerializeField]
    private Text Score4;

    [SerializeField]
    private Text Score5;



    [SerializeField]
    private GameObject mainScene;

    [SerializeField]
    private GameObject highscoreScene;

	// Use this for initialization
	void Start () {
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        getScores();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EndGame()
    {
        GameManager.GetComponent<LoaderScript>().EndGameFunction();
    }

    void getScores()
    {
        int[] scores = GameManager.GetComponent<LoaderScript>().returnHighScores();
        Score1.text = scores[0].ToString();
        Score2.text = scores[1].ToString();
        Score3.text = scores[2].ToString();
        Score4.text = scores[3].ToString();
        Score5.text = scores[4].ToString();
        hideHSScene();
    }

    public void hideHSScene()
    {
        highscoreScene.SetActive(false);
        mainScene.SetActive(true);
    }

    public void hideMScene()
    {
        mainScene.SetActive(false);
        highscoreScene.SetActive(true);
    }

    public void playGame()
    {
        Application.LoadLevel(2);
    }
}
