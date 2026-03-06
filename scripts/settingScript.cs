using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class settingScript : MonoBehaviour
{
    public Text bestScoreText;
    public static int bestScore = 0;

    void Start()
    {

        bestScoreText.text = "Best score: " + scoreScript.bestScore.ToString();

    }

  

    void TriggerJump()
    {
        Debug.Log("Jump!");
    }

    void Awake()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        PlayerPrefs.Save();
    }

    public void ResetHighScore()
    {
        bestScoreText.text = "Best score: 0";

        PlayerPrefs.DeleteKey("BestScore");
        PlayerPrefs.Save();
        MusicManager.Instance.ResetIntenseMusic();
    }

    public static void TrySetNewBestScore(int currentScore)
    {
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("BestScore", currentScore);
            PlayerPrefs.Save();
        }
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