using System;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;

    public AudioSource audioSource;
    public AudioClip[] menuClips;
    public AudioClip intenseGameClip;

    private int currentMenuIndex = 0;
    private bool intenseMusicPlayed = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();

            LoadMusicState();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayCurrentMenuMusic()
    {
        if (menuClips.Length == 0) return;
        PlayMusic(menuClips[currentMenuIndex]);
    }

    public void NextMenuTrack()
    {
        if (menuClips.Length == 0) return;

        currentMenuIndex = (currentMenuIndex + 1) % menuClips.Length;
        PlayCurrentMenuMusic();
        SaveMusicState();
    }


    public void PlayIntenseGameMusic()
    {
        if (!intenseMusicPlayed)
        {
            PlayMusic(intenseGameClip);
            intenseMusicPlayed = true;
        }
    }

    private void PlayMusic(AudioClip clip)
    {
        if (audioSource.clip == clip) return;
        audioSource.clip = clip;
        audioSource.Play();
    }

    

  

    private void SaveMusicState()
    {
        PlayerPrefs.SetInt("MusicIndex", currentMenuIndex);
        PlayerPrefs.SetInt("IntensePlayed", intenseMusicPlayed ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void LoadMusicState()
    {
        currentMenuIndex = PlayerPrefs.GetInt("MusicIndex", 0);
        intenseMusicPlayed = PlayerPrefs.GetInt("IntensePlayed", 0) == 1;

        if (menuClips.Length > 0 && currentMenuIndex < menuClips.Length)
            PlayCurrentMenuMusic();

    }

    public void ResetIntenseMusic()
    {
        intenseMusicPlayed = false;
        PlayerPrefs.SetInt("IntensePlayed", 0);
        PlayerPrefs.Save();
    }
}

   /* void Awake()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    public void PlayMenuMusic()
    {
        if (menuClips.Length > 0)
        {
            AudioClip randomClip = menuClips[UnityEngine.Random.Range(0, menuClips.Length)];
            PlayMusic(randomClip);
        }
    }

    public void PlayGameMusic()
    {
        PlayMusic(gameClip);
    }

    public void PlayIntenseGameMusic()
    {
        PlayMusic(intenseGameClip);
    }

    private void PlayMusic(AudioClip clip)
    {
        if (audioSource.clip == clip) return;
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void Mute(bool mute)
    {
        isMuted = mute;
        audioSource.mute = mute;
    }

    public bool IsMuted()
    {
        return isMuted;
    }*/
