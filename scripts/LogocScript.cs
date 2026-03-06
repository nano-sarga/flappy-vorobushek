using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
    
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public GameObject RecordScreen;
    public Text bestScoreText;
    private int currentScore;
    bool intenseMusicPlayed = false;

    void Start()
    {
        bestScoreText.text = "Best score: " + scoreScript.bestScore.ToString();
    }

    void Update()
    {
        if (playerScore >= 45 && !intenseMusicPlayed)
        {
            MusicManager.Instance.PlayIntenseGameMusic();
            intenseMusicPlayed = true;
        }
    }


    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        Debug.Log("Добавлены очки: " + scoreToAdd);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        bool isNewRecord = scoreScript.TrySetNewBestScore(playerScore);
        bestScoreText.text = "Best score: " + scoreScript.bestScore.ToString();

            GameOverScreen.SetActive(true);
         
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}

