using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
   // public Text scoreText;
   
    //Use this for initialization
    void Start()
    {
       // gameObject.SetActive(false);
    }
    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitgame()
    {
        Debug.Log("Exit Buttn Pressed");
        Application.Quit();
    }
    //public void ToggleEndMenu(int score)
    //{
    //    gameObject.SetActive(true);
    //    scoreText.text = ((int)score).ToString();
    //}
}