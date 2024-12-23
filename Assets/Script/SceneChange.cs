using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void IntroToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void BackIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
