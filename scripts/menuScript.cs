using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public Text bestScoreText;

    void Start()
    {
        bestScoreText.text = "Best score: " + scoreScript.bestScore.ToString();
        
    }
    public void OnNextTrackButton()
    {
        MusicManager.Instance.NextMenuTrack();
    }

    public void goToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void PlayGame() {
        SceneManager.LoadScene("Main Scene");
    }

    public void QuitGame() {
        Application.Quit();
    }
    
}
