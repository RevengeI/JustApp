using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Text score, highScore;
    public int scoreCount = 0, highScoreCount;

    public static Character instance;                         

    float horizontal;                                       
    public Rigidbody2D CharacterRig;

    void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("SaveScore"))
        {
            highScoreCount = PlayerPrefs.GetInt("SaveScore");
        }
    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    
    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)   
        {
            horizontal = Input.acceleration.x;                 
        }

        if (Input.acceleration.x < 0)                        
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;   
        }

        if (Input.acceleration.x > 0)                        
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;     
        }

        CharacterRig.velocity = new Vector2(Input.acceleration.x * 10f, CharacterRig.velocity.y);

        
        score.text = "Score: " + scoreCount;
        highScore.text = "High Score: " + highScoreCount;
    }

    public void OnCollisionEnter2D(Collision2D collision)       
    {
        if (collision.collider.name == "DeadZone")              
        {
            SceneManager.LoadScene(0);                         
        }
    }

    public void AddScore()
    {
        scoreCount++;
        HighScore();
    }

    public void HighScore()
    {
        if (scoreCount >= highScoreCount)
        {
            highScoreCount = scoreCount;
        }

        PlayerPrefs.SetInt("SaveScore", highScoreCount);
    }
}
