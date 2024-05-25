using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ctrl : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    private void Start()
    {
        _musicSlider.value = 100;
        _sfxSlider.value = 100;
    }
    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();

    }
    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }
    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }
    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
