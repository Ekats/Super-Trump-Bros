using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour
{
    public Manager manager;
    public BoxCollider2D col;
    public BoxCollider2D colb;
    public ParticleSystem par;
    public AudioClip Pong;
    AudioSource audio;

    void Awake()
    {
        gameObject.SetActive(true);
    }
    IEnumerator Countdown(double secondsLeft)
    {
        while (secondsLeft > 0f)
        {
            secondsLeft -= Time.deltaTime;
            yield return null;
        }
        Debug.Log("Countdown finished!");
        col.GetComponent<Rigidbody2D>().AddForce(Physics.gravity * 10);
        col.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Contains("Player"))
        {
            par.GetComponent<ParticleSystem>().Play();
            par.GetComponent<AudioSource>().PlayOneShot(Pong, 0.7F);
            colb.enabled = false;
            StartCoroutine(Countdown(0.5));
            manager.ScoreAdd10();
        }

    }
}