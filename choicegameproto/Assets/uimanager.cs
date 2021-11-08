using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{
    public int languageno;
    public GameObject languagepanel,soundbutton,settingpanel;
    public Sprite[] soundsp;
    public bool issoundon;
    public Button soundbut;
    
    // Start is called before the first frame update
    void Start()
    {
        languageno = PlayerPrefs.GetInt("languagesetted");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        PlayerPrefs.SetInt("languagesetted", languageno);
    }
    public void languageset()
    {
        if(EventSystem.current.currentSelectedGameObject.name=="english")
        {
            languageno = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }else if(EventSystem.current.currentSelectedGameObject.name=="hindi")
        {
            languageno = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(EventSystem.current.currentSelectedGameObject.name=="telugu")
        {
            languageno = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    public void buttonpresses()
    {
      if (EventSystem.current.currentSelectedGameObject.name=="languageopen")
        {
            languagepanel.SetActive(true);
        }
      if (EventSystem.current.currentSelectedGameObject.name=="close")
        {
            languagepanel.SetActive(false);
        }
      if (EventSystem.current.currentSelectedGameObject.name=="sound")
        {
            if(issoundon==true)
            {
                issoundon = false;
             soundbut= soundbutton.GetComponent<Button>();
                soundbut.image.sprite = soundsp[1];
                
            }
            else
            {
                issoundon = true;
                soundbut = soundbutton.GetComponent<Button>();
                soundbut.image.sprite = soundsp[0];
            }
        }
      if(EventSystem.current.currentSelectedGameObject.name == "settings")
        {
            if(settingpanel.transform.localScale.y==0)
            {
                settingpanel.transform.localScale= new Vector3(1,1,1);
            }else if(settingpanel.transform.localScale.y == 1)
            {
                settingpanel.transform.localScale = new Vector3(1,0,1);
            }
        }
    }
    
}
