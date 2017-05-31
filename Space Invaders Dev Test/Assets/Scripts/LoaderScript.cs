using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderScript : MonoBehaviour {

    private int HighScore1;
    private int HighScore2;
    private int HighScore3;
    private int HighScore4;
    private int HighScore5;

    private int TimesPlayed;



	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        HighScore1 = PlayerPrefs.GetInt("HighScore1");
        HighScore2 = PlayerPrefs.GetInt("HighScore2");
        HighScore3 = PlayerPrefs.GetInt("HighScore3");
        HighScore4 = PlayerPrefs.GetInt("HighScore4");
        HighScore5 = PlayerPrefs.GetInt("HighScore5");
        TimesPlayed = PlayerPrefs.GetInt("TimesPlayed");

        Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Check Which score to change function





    //Change high score function





    public void TimesPlayedIncrease()
    {
        TimesPlayed++;
    }


    
    //Exit Function
    public void EndGameFunction()
    {
        PlayerPrefs.SetInt("HighScore1", HighScore1);
        PlayerPrefs.SetInt("HighScore2", HighScore2);
        PlayerPrefs.SetInt("HighScore3", HighScore3);
        PlayerPrefs.SetInt("HighScore4", HighScore4);
        PlayerPrefs.SetInt("HighScore5", HighScore5);
        PlayerPrefs.SetInt("TimesPlayed", TimesPlayed);
        Application.Quit();
    }

    public int[] returnHighScores()
    {
        int[] scores;
        scores = new int[5];
        scores[0] = HighScore1;
        scores[1] = HighScore2;
        scores[2] = HighScore3;
        scores[3] = HighScore4;
        scores[4] = HighScore5;
        return scores;
    }

}
