using System;
using System.Collections.Generic;

public class Encoders
{
    // Pre-defining the ordered alphabets and integers for ease of access in all functions that need it
    char[] upperAlphabet;
    char[] lowerAlphabet;
    int[] integers;

    public Encoders()
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
        shuffle = shuffle % 26;
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
                // Takes the index of the char in the plaintext string, adds that (also works with negative numbers) to the index, and adds the new char in the array to 'encodedStr'
                char newCh = upperAlphabet[(Array.IndexOf(upperAlphabet, ch) + shuffle)];
                encodedStr += newCh;
                continue;
            }
            
            if(Char.IsLower(ch))
            {
                // Same as above but with a different array
                char newCh = lowerAlphabet[(Array.IndexOf(lowerAlphabet, ch) + shuffle)];
                encodedStr += newCh;
                continue;
            }
            
            // If the character is not a numerical or alphabetical character, add it without shuffling it.
            encodedStr += ch;
        }

        return encodedStr;
    }

    // TEMPORARILY RETURNING VOID, WILL BE RETURNING STRING IN THE FUTURE
    public string monoalphabeticCipher(string plaintext, string key)
    {
        if (string.IsNullOrEmpty(plaintext))
        {
            return "";
        }

        if (key.Length != 26)
        {
            return "Key is not 26 letters.";
        }

        foreach(char ch in plaintext)
        {
            if(!char.IsLetter(ch))
            {
                return "The key must be all letters.";
            }
        }

        string plaintextLower = plaintext.ToLower();
        string plaintextUpper = plaintext.ToUpper();
        string encodedStr = "";

        Dictionary<char, char> keyValueDict = new();

        for(int i = 0; i <= 25; i++)
        {
            keyValueDict.Add(lowerAlphabet[i], plaintextLower[i]);
        }

        foreach(char ch in plaintext)
        {
            char newCh = keyValueDict[ch];
            encodedStr += newCh;
        }

        return encodedStr;
    }
}