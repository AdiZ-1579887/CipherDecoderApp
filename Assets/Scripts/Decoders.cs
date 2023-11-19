using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Decoders : MonoBehaviour
{
    // Pre-defining the ordered alphabets and integers for ease of access in all functions that need it
    char[] upperAlphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    char[] lowerAlphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    int[] integers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    // Decodes an input string 'encodedStr' by moving letters forward 'shuffle' times, e.g. if shuffle = 5, a -> f
    public string CaesarCipher(string encodedStr, int shuffle)
    {
        if (string.IsNullOrEmpty(encodedStr))
        {
            return "";
        }
        
        string decodedStr = "";
        foreach(char ch in encodedStr)
        {
            // Digits remain unchanged
            if(Char.IsDigit(ch))
            {
                decodedStr += ch;
            } else if(Char.IsUpper(ch))
            {
                // Takes the index of the char in the ENCODED string, adds that (also works with negative numbers) to the index, and adds the new char in the array to 'decodedStr'
                char newCh = Convert.ToChar(upperAlphabet[(Array.IndexOf(upperAlphabet, ch) + shuffle)]);
                decodedStr += newCh;
            } else if(Char.IsLower(ch))
            {
                char newCh = Convert.ToChar(lowerAlphabet[(Array.IndexOf(lowerAlphabet, ch) + shuffle)]);
                decodedStr += newCh;
            }
            else
            {
                decodedStr += ch;
            }
        }
        return decodedStr;
    }
}
