using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadStringInput : MonoBehaviour
{
    public string input;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
