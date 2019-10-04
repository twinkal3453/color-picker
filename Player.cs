using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string currentColor;
    public float jumpForce = 10f;
    public Rigidbody2D circle;
    public SpriteRenderer sr;
    public GameObject[] obsticle;
    public GameObject colorChanger;
    public Color blue;
    public Color yellow;
    public Color red;
    public Color asmani;
    public static int score = 0;
    public Text HScore;
    public Text scoreText;
    public DeathMenu deathMenu;

   //using this for initialization
    void Start()
    {
        setRandomColor();
        //if you want to reset score whenever you start
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("jump") || Input.GetMouseButtonDown(0))
        {
            circle.velocity = Vector2.up * jumpForce;
        }
        HighScore();
        HScore.text = PlayerPrefs.GetInt("HScore").ToString();
        scoreText.text = score.ToString();

    }
   
    public void HighScore()
    {
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("HScore"))
        {
            int h = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("HScore", h);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Scored")
        {
            score = score + 5;
            HScore.text = score.ToString();
            PlayerPrefs.SetInt("score", score);
            HighScore();
            Destroy(collision.gameObject);
            int randomNumber = Random.Range(0, 2);
            if (randomNumber == 0)
            {
                Instantiate(obsticle[0], new Vector2(transform.position.x, transform.position.y + 10f), transform.rotation);
            }
            else
            {
                Instantiate(obsticle[1], new Vector2(transform.position.x, transform.position.y + 10f), transform.rotation);
            }
            return;
        }
        if(collision.tag == "ColorChanger")
        {
            setRandomColor();
            Destroy(collision.gameObject);
            Instantiate(colorChanger, new Vector2(transform.position.x, transform.position.y + 10f), transform.rotation);
            return;
        }

        if(collision.tag != currentColor)
        {
            SceneManager.LoadScene(2);
            score = 0;
        }
        
    }
    void setRandomColor()
    {
        int rand = Random.Range(0, 4);

        switch (rand)
        {
            case 0:
                currentColor = "Blue";
                sr.color = blue;
                break;

            case 1:
                currentColor = "Yellow";
                sr.color = yellow;
                break;

            case 2:
                currentColor = "Red";
                sr.color = red;
                break;

            case 3:
                currentColor = "Asmani";
                sr.color = asmani;
                break;
         
        }
       
    }
}
