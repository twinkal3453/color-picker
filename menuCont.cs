using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuCont : MonoBehaviour
{
    public GameObject playButton;
    public GameObject muteButton;
    public GameObject menu;
    public GameObject ok;

    public GameObject Camera;
    public Text SoundButtonText;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GetOptions()
    {
        playButton.SetActive(false);
        muteButton.SetActive(true);
        menu.SetActive(false);
        ok.SetActive(true);
    }
    public void okey()
    {
        playButton.SetActive(true);
        menu.SetActive(true);
        ok.SetActive(false);
        muteButton.SetActive(false);
    }
   public void MuteSound()
   {
        if (Camera.GetComponent<AudioSource>().mute)
        {
            Camera.GetComponent<AudioSource>().mute = false;
            SoundButtonText.text = "Mute Sound";
            PlayerPrefs.SetInt("mute", 0);
        }
        else
        {
            Camera.GetComponent<AudioSource>().mute = true;
            SoundButtonText.text = "Unmute Sound";
            PlayerPrefs.SetInt("mute", 1);
        }
    }

}
