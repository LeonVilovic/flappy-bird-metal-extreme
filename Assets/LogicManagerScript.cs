using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public int lifePoints;
    public Text scoreText;
    public Text lifeText;
    public GameObject gameOverScreen;
    public Boolean gravitateToX;
    public float gravitateToXDelayTime = 1.0f;
    public PipeSpawnerScrip PipeSpawner;

    private void Start()
    {
        gameOverScreen.SetActive(false);
        //TODO
        PipeSpawner = GameObject.FindGameObjectWithTag("PipeSpawner").GetComponent<PipeSpawnerScrip>();
        Debug.Log("PipeSpawner reference: " + PipeSpawner);
    }


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        if (playerScore % 3 == 0) { increasePipeSpawnSpeed(); }    
    }

    public void reduceLifePoints()
    {
        lifePoints = lifePoints - 1;
        lifeText.text = lifePoints.ToString();
    }

    public void restartGame()
    {
        Debug.Log("restartGame() function triggerd");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
            gameOverScreen.SetActive(true);    
    }
    public void applicationQuit()
    {
        Application.Quit();
    }

    public void increasePipeSpawnSpeed()
    {
           PipeSpawner.Timer = PipeSpawner.Timer-1;
         //PipeSpawner.Timer
    }

}
