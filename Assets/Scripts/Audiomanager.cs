using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;
    private void Awake()
    {
         if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource gameSource;



    public AudioClip music;
    public AudioClip sfx;
    public AudioClip game;


    private void Start()
    {
        musicSource.clip = music;
        //musicSource.Play();

        gameSource.clip = sfx;
       // sfxSource.Play();


        if (SceneManager.GetActiveScene().name == "Menu")
        {
        }

        print("start audio manager");
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

    public void GameSoundStart()
    {
        gameSource.clip = game;
        gameSource.Play();
    }
    public void GameSoundStop()
    {
        gameSource.clip = game;
        gameSource.Stop();
    }



    private void Update()
    {
      
        
    }



}


