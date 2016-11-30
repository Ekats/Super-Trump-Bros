using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerSmash : MonoBehaviour {
    public int Score = 0;
    public int TrumpHealth = 3;
    public int ClintonHealth = 3;
    public Text gameOver;
    public GameObject Trump;
    public GameObject Clinton;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;
    public GameObject Heart6;

    void Start()
    {
        Score = 0;
    }


    void Update() {
        if (TrumpHealth == 2){Heart3.SetActive(true);
        if (TrumpHealth <= 2) { Heart3.SetActive(false); }}
        if (TrumpHealth == 1){ Heart2.SetActive(true);
        if (TrumpHealth <= 1) { Heart2.SetActive(false); }}
        if (TrumpHealth == 0){ Heart1.SetActive(true);
        if (TrumpHealth <= 0) { Heart1.SetActive(false); }}
        if (ClintonHealth == 2){ Heart4.SetActive(true);
        if (ClintonHealth <= 2) { Heart4.SetActive(false); }}
        if (ClintonHealth == 1){ Heart5.SetActive(true);
        if (ClintonHealth <= 1) { Heart5.SetActive(false); }}
        if (ClintonHealth == 0){ Heart6.SetActive(true);
        if (ClintonHealth <= 0) { Heart6.SetActive(false); }}


        if (TrumpHealth <= 0)
        {
            gameOver.text = "GAME OVER";
            SceneManager.LoadScene("TitleScreen");
        }

    }

    public void LoseHealthT(int Damage)
    {
        TrumpHealth -= Damage;
        print (TrumpHealth);
    }
    public void LoseHealthC(int Damage)
    {
        ClintonHealth -= Damage;
        print(ClintonHealth);
    }
}
