using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int bestScore = 0;
    public Text bestScoreText;

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
    }

    public static bool TrySetNewBestScore(int currentScore)
    {
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("BestScore", currentScore);
            PlayerPrefs.Save();
            return true;
        }
        return false;
    }
}
