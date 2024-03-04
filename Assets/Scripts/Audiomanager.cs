using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    private void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            SoundManagerData();
        }
        else
        {
            SoundManagerData();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SoundManagerSave();
    }

    private void SoundManagerData()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SoundManagerSave()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}

