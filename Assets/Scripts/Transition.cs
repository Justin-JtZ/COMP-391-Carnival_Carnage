using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
     void switchToStart()
    {
        SceneManager.LoadScene("Start Screen");
    }

    void switchToGame()
    {
        SceneManager.LoadScene("Game");
    }

    void switchToOverview()
    {
        SceneManager.LoadScene("Overview");
    }

    void switchToControls()
    {
        SceneManager.LoadScene("Controls");
    }
}
