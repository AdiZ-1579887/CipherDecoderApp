using System;
using UnityEngine;


public class Encoders : MonoBehaviour
{
    // Pre-defining the ordered alphabets and integers for ease of access in all functions that need it
    char[] upperAlphabet;
    char[] lowerAlphabet;
    int[] integers;

    // Start is called before the first frame update
    void Start()
    {
        // Fetch lists from ListConstants.cs to ensure that it is fully updated.
        upperAlphabet = ListConstants.upperAlphabet;
        lowerAlphabet = ListConstants.lowerAlphabet;
        integers = ListConstants.integers;
    }   

    public string ShiftCaesarCipher(string plaintext, int shuffle)
    {
        if (string.IsNullOrEmpty(plaintext))
        {
            return "";
        }

        string encodedStr = "";
        foreach(char ch in plaintext)
        {
            // Digits remain unchanged
            if(Char.IsDigit(ch))
            {
                encodedStr += ch;
                continue;
            }
            
            if(Char.IsUpper(ch))
            {
                // Takes the index of the char in the ENCODED string, adds that (also works with negative numbers) to the index, and adds the new char in the array to 'decodedStr'
                char newCh = Convert.ToChar(upperAlphabet[(Array.IndexOf(upperAlphabet, ch) + shuffle)]);
                encodedStr += newCh;
                continue;
            }
            
            if(Char.IsLower(ch))
            {
                char newCh = Convert.ToChar(lowerAlphabet[(Array.IndexOf(lowerAlphabet, ch) + shuffle)]);
                encodedStr += newCh;
                continue;
            }
            
            // If the character is not a digit or alphabetical character, add it without shuffling it.
            encodedStr += ch;
        }
        return encodedStr;
    }
}
