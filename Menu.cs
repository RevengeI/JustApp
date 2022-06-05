using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Menu_Start_Button(int a)
    {
        SceneManager.LoadScene(a);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("SaveScore");
    }
}
