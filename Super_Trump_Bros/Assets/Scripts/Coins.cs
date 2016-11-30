using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour
{
    public Manager man;
    public BoxCollider2D col;
    public ParticleSystem par;
    public AudioClip Ping2;
    AudioSource audio;

    void Awake()
    {
        gameObject.SetActive(true);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Contains("Player"))
        {
            gameObject.SetActive(false);
            par.GetComponent<ParticleSystem>().Play();
            par.GetComponent<AudioSource>().PlayOneShot(Ping2, 0.7F);
            man.ScoreAdd1();
        }

    }
}