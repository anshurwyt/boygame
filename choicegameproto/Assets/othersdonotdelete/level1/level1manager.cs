using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level1manager : MonoBehaviour
{
    public GameObject[] phases;
    public int currphase, tempphase;
    public float phase1to2delay, phase2to3delay, windelay, lossdelay, choicedelay;
    public GameObject winpanel, losepanel,mainui;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        phases[0].SetActive(true);
        currphase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currphase == 0)
        {
            phases[0].SetActive(true);
            tempphase = 1;
            Invoke("phaseinc", phase1to2delay);
        }
        else if (currphase == 1)
        {
            
            phases[0].SetActive(false);
            phases[1].SetActive(true);


        }
        else if (currphase == 2)
        {
            phases[1].SetActive(false);
            phases[2].SetActive(true);
            Invoke("winmenu", windelay);
        }
        else if (currphase == 3)
        {
            phases[1].SetActive(false);
            phases[3].SetActive(true);
            Invoke("losemenu", lossdelay);
        }
    }
    public void choice1()
    {
        tempphase = 2;
        Invoke("phaseinc", choicedelay);
    }
    public void choice2()
    {
        tempphase = 3;
        Invoke("phaseinc", choicedelay);
    }
    public void phaseinc()
    {
        currphase = tempphase;
    }
    public void gameover()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void win()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void winmenu()
    {
        mainui.SetActive(false);
        Time.timeScale = 0.2f;
        winpanel.SetActive(true);
    }
    public void losemenu()
    {
        mainui.SetActive(false);
        Time.timeScale = 0.2f;
        losepanel.SetActive(true);
    }
}
