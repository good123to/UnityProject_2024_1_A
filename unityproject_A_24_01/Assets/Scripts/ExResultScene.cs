using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExResultScene : MonoBehaviour
{
    public Text TextUI;

    public void Start()
    {
        TextUI.text = PlayerPrefs.GetInt("Point").ToString();
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
