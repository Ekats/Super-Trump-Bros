using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public Canvas MainCanvas;
public Canvas OptionsCanvas;
public Canvas PlayCanvas;
public Canvas SmashCanvas;

    void Awake()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.gameObject.SetActive(true);
        MainCanvas.enabled = true;
    }

    public void OptionsOn()
    {
    OptionsCanvas.gameObject.SetActive(true);
    OptionsCanvas.enabled = true;
    MainCanvas.enabled = false;
    }


    public void BackOn0()
    {
    OptionsCanvas.enabled = false;
    PlayCanvas.enabled = false;
    MainCanvas.enabled = true;
    MainCanvas.gameObject.SetActive(true);
    }

    public void BackOn1()
    {
        SmashCanvas.enabled = false;
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        PlayCanvas.enabled = true;
        PlayCanvas.gameObject.SetActive(true);
    }

    public void PlayOn()
    {
    PlayCanvas.gameObject.SetActive(true);
    PlayCanvas.enabled = true;
    MainCanvas.enabled = false;
    }

    public void SmashOn()
    {
    SmashCanvas.gameObject.SetActive(true);
    SmashCanvas.enabled = true;
    PlayCanvas.enabled = false;
    }

    public void LoadSmashOn()
    {
        SceneManager.LoadScene("SmashStage");
    }
    public void LoadPlatOn()
    {
        SceneManager.LoadScene("Platformer");
    }
}