using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Decoders : MonoBehaviour
{
    // Pre-defining the ordered alphabets and integers for ease of access in all functions that need it
    string[] lowerAlphabet = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
    string[] upperAlphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
    int[] integers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Decodes an input string 'encodedStr' by moving letters forward 'shuffle' times, e.g. if shuffle = 5, a -> f
    public string caesarCipher(string encodedStr, int shuffle)
    {
        string decodedStr = "";
        foreach(char ch in encodedStr)
        {
            // Digits remain unchanged (is this how the real cipher works?)
            if(Char.IsDigit(ch))
            {
                decodedStr += ch;
            } else if(Char.IsUpper(ch))
            {
                // Move the array 'shuffle' times in the upperAlphabet array
            } else
            {
                // Here, the character must be a lower case letter in the alphabet
                // Move the array 'shuffle' times in the lowerAlphabet array
            }
        }
        return decodedStr;
    }
}
