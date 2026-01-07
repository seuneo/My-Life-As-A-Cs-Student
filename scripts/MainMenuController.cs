using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

public GameObject sound;
public GameObject soundh;

    public void playGame()
    {
	Instantiate(sound, transform.position, Quaternion.identity);
        SceneManager.LoadScene("SampleScene"); //this will have the name of your main game scene
    }

    public void restart()
    {
	Instantiate(sound, transform.position, Quaternion.identity);
        SceneManager.LoadScene("startmenu"); //this will have the name of your main menu scene
    }

    public void exitGame()
    {
	Instantiate(soundh, transform.position, Quaternion.identity);
        Application.Quit();
    }
}