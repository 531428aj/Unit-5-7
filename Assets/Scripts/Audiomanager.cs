using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager Instance;
    private void Awake()
    {
         if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;



    public AudioClip music;
    public AudioClip sfx;

    

    private void Start()
    {
        musicSource.clip = music;
        musicSource.Play();

        sfxSource.clip = sfx;
        sfxSource.Play();

    }

    public void SFXSoundStart()
    {
        sfxSource.clip = sfx;
        sfxSource.Play();
    }
    public void SFXSoundStop()
    {
        sfxSource.clip = sfx;
        sfxSource.Stop();
    }
    public void MenuSoundStart()
    {
        musicSource.clip = music;
        musicSource.Play();
    }
    public void MenuSoundStop()
    {
        musicSource.clip = music;
        musicSource.Stop();
    }


    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            
            SFXSoundStop();
            MenuSoundStop();
        }
        

        if (SceneManager.GetActiveScene().name == "Menu")
        {
            


            SFXSoundStart();
            MenuSoundStart();
        }
        
    }



}


