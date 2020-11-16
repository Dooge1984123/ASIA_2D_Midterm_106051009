using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    
    public void StartGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡");
        //SceneManager.LoadScene(1);
    }

 
    public void QuitGame()
    {
        print("結束遊戲");
        Application.Quit();
    }
}
