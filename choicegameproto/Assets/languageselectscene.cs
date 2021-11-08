using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class languageselectscene : MonoBehaviour
{

    public int isloaded = 0;
    // Start is called before the first frame update
    void Start()
    {
        isloaded= PlayerPrefs.GetInt("isload");
        if (isloaded == 0)
        {
           

        }
        else if(isloaded == 1)
        {
            SceneManager.LoadScene("test");
        }

        
    }

    // Update is called once per frame
    void Update()
    {

       
        
    }
    public void nextscene()
    {
        SceneManager.LoadScene("test");
        isloaded = 1;
        PlayerPrefs.SetInt("isload", isloaded);
    }
}
