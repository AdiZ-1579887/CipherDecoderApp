using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using static Decoders;

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

    string ArrayOfWords(string s)
    {
        // Returns a string in which 0-9, A-Z, a-z, and ' ' are allowed, but everything else is removed.
        return Regex.Replace(s, "[^0-9A-Za-z ]", "");
    }

    void CaesarCipher(string encodedStr)
    {
        if (string.IsNullOrEmpty(encodedStr))
        {
            return;
        }

        // Loop over words in string and compare with common words from ListConstants.cs
        string[] arrOfWords = ArrayOfWords(encodedStr).Split();
    }
}