using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject Camera;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("mute"))
        {
            if(PlayerPrefs.GetInt("mute") == 0)
            {
                Camera.GetComponent<AudioSource>().mute = false;
            }
            else if (PlayerPrefs.GetInt("mute") == 1)
            {
                Camera.GetComponent<AudioSource>().mute = true;
            }
            else
            {
                Camera.GetComponent<AudioSource>().mute = false;
            }
        }
    }

   
}
