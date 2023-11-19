using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteForceDecoder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string[] FindWords(string encodedStr)
    {
        // Remove all special characters.
        int i = 0;
        foreach(char ch in encodedStr)
        {
            if(!Char.IsLetterOrDigit(ch))
            {
                encodedStr
            }
        }
    }
    void CaesarCipher(string encodedStr)
    {
        if (string.IsNullOrEmpty(encodedStr))
        {
            return;
        }

        // Loop over words in string and compare with common words from ListConstants.cs
    }
}
