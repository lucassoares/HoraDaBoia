using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Canvas menuPause;

    public void menuPauseJogar()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1;
    }
	public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void Continue()
    {
        menuPause.enabled = false;
        Time.timeScale = 1;
    }
}
