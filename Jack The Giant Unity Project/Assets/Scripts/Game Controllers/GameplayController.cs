﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [SerializeField]
    private Text scoreText,coinText,lifeText,gameOverScoreText,gameOverCoinText;
    [SerializeField]
    private GameObject pausePanel,gameOverPanel;

    [SerializeField]
    private GameObject readyButton;





    
   void Awake() {
       MakeIntstance();
   }


   void  Start() {
       Time.timeScale = 0f;
   }

   
    void MakeIntstance(){
        if(instance == null){
            instance = this;
        }
    }


    public void GameOverShowPanel(int finalScore,int finalCoinScore){
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = finalScore.ToString();
        gameOverCoinText.text  = finalCoinScore.ToString();
        StartCoroutine(GameOverLoadMainMenu());
    }

    IEnumerator GameOverLoadMainMenu(){
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenu");
    }

    public void SetScore(int score){
        scoreText.text = "x" + score;
    }

    public void SetCoinScore(int coinScore){
        coinText.text = "x" + coinScore;
    }

    public void SetLifeScore(int lifeScore){
        lifeText.text = "x" + lifeScore;
    }

    public void PauseTheGame(){
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void ResumeGame(){
         Time.timeScale = 1f;
         pausePanel.SetActive(false);
    }

    public void QuitGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void StartTheGame(){
        Time.timeScale =  1f;
        readyButton.gameObject.SetActive(false);
    }
}
