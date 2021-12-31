using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string firstLevel;
    public string levelSelect;

    public string[] levelNames;

    public int startingLives;

    public AudioSource menuMusic;

	// Use this for initialization
	void Start () {
        menuMusic.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewGame()
    {
        //menuMusic.Stop();
        SceneManager.LoadScene(firstLevel);

        for(int i = 0; i < levelNames.Length; i++)
        {
            PlayerPrefs.SetInt(levelNames[i], 0); // locking all the levels for a new game
        }

        PlayerPrefs.SetInt("CoinCount", 0);
        PlayerPrefs.SetInt("PlayerLives", startingLives);

    }

    public void Continue()
    {
        //menuMusic.Stop();
        SceneManager.LoadScene(levelSelect);
    }

    public void QuitGame()
    {
        //menuMusic.Stop();
        Application.Quit();
    }

}
