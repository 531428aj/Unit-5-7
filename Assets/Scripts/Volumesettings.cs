using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volumesettings : MonoBehaviour
{
    public static Volumesettings instance;

    public bool stopAudio;
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider gameSlider;
    
    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetGameVolume();
            
        }

       
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioMixer.SetFloat("Music", volume);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetGameVolume()
    {
        float volume = gameSlider.value;
        audioMixer.SetFloat("SFX", volume);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }



    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        gameSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetGameVolume();
        
    }

    private void Update()
    {
    }

}

