using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralimit : MonoBehaviour
{
    public float camlimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>camlimit)
        {
            transform.position = new Vector3(camlimit, transform.position.y, transform.position.z);
        }
    }
}
