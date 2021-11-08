using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class langagechanger : MonoBehaviour
{
    public Sprite[] sps;
    public int language;
    public bool shouldscale, shouldoffset;
    public Vector3 offset, scaleoffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        language = FindObjectOfType<uimanager>().languageno;
        if(language==0)
        {
            GetComponent<SpriteRenderer>().sprite = sps[0];
        }
        else if(language==1)
        {
            if (shouldscale == true)
            {
                transform.localScale = scaleoffset;
            }
            if (shouldoffset == true)
            {
                transform.position = offset;
            }
            GetComponent<SpriteRenderer>().sprite = sps[1];
        }
        else if (language == 2)
        {
            if (shouldscale == true)
            {
                transform.localScale = scaleoffset;
            }
            if (shouldoffset == true)
            {
                transform.position = offset;
            }
            GetComponent<SpriteRenderer>().sprite = sps[2];
        }

    }
  

}
