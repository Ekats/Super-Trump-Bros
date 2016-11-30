using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    public int Score = 0;
    public int Health = 5;
    public Text scoreText;
    public Text gameOver;
    public GameObject Trump;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;

    void Start()
    {
        Score = 0;
    }


    void Update() {
        if (Health == 4){ Heart5.SetActive(true);
        if (Health <= 4) { Heart5.SetActive(false); }}
        if (Health == 3){ Heart4.SetActive(true);
        if (Health <= 3) { Heart4.SetActive(false); }}
        if (Health == 2){ Heart3.SetActive(true);
        if (Health <= 2) { Heart3.SetActive(false); }}
        if (Health == 1){ Heart2.SetActive(true);
        if (Health <= 1) { Heart2.SetActive(false); }}
        if (Health == 0){ Heart1.SetActive(true);
        if (Health <= 0) { Heart1.SetActive(false); }}

        if (Health <= 0)
        {
            gameOver.text = "GAME OVER";
            SceneManager.LoadScene("TitleScreen");
        }

    }
    public void ScoreAdd1()
        {
        Score += 1;
        print(Score);
        SetScoreText();
        }
    public void ScoreAdd10()
    {
        Score += 10;
        print(Score);
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + Score.ToString();
        if (Score >= 100)
        {
            print("1UP");
        }
    }

    public void LoseHealth(int Damage)
    {
        Health -= Damage;
        print (Health);
    }
}
