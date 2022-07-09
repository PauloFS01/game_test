using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string resut = FindObjectOfType<cube>().PrintFromOutSide();
        print(resut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
