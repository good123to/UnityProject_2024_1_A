using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    
    public void GoToShootGame()
    {
        SceneManager.LoadScene("GameScene_Gun");
    }

    public void GoToJump()
    {
        SceneManager.LoadScene("GameScene_jump");
    }

    public void GoExit()
    {
        Application.Quit(0);
    }
}
