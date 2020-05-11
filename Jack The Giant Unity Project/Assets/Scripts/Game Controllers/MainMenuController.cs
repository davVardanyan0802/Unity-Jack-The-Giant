using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame(){
        GameMengr.instance.gameStartedFromMainMenu = true;
         SceneManager.LoadScene("GamePlay");
    }

    public void HighScoreMenu(){
        SceneManager.LoadScene("HighScoreScene");
    }

    public void OptionsMenu(){
        SceneManager.LoadScene("OptionsMenuScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void MusicButton(){
        
    }
   
}
