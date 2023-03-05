using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScene;
    public GameObject deathSound;
    private bool soundPlayed = false;
    public AudioSource pointSound;
    [ContextMenu("Increase Score")]

    void Start()
    {

    }
    public void addScore(int scoreToAdd)
    {

        playerScore += scoreToAdd;
        pointSound.Play();
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (!soundPlayed)
        {
            Instantiate(deathSound);
            soundPlayed = true;
        }

        gameOverScene.SetActive(true);
    }

}
