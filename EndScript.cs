using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
   
   
   
    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }
     //when you press exit button then applicantion will close
    public void exitgame()
    {
        Debug.Log("Exit Buttn Pressed");
        Application.Quit();
    }
   
}
