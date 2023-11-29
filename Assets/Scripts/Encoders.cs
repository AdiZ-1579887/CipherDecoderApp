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
        // Empty strings return nothing
        if (string.IsNullOrEmpty(plaintext))
        {
            return "";
        }

        // Ensures that the key provided covers the full alphabet
        if (key.Length != 26)
        {
            return "Key is not 26 letters.";
        }

        // Ensures that the key provided has no non-alphabetical characters
        foreach(char ch in plaintext)
        {
            if(!char.IsLetter(ch))
            {
                return "The key must be all letters.";
            }
        }

        string plaintextLower = plaintext.ToLower();
        string plaintextUpper = plaintext.ToUpper();

        // This ensures that the user-entered key in case-insensitive
        string keyLower = key.ToLower();
        string keyUpper = key.ToUpper();
        string encodedStr = "";

        Dictionary<char, char> keyValueDict = new();

        // Generates a dictionary containing upper and lowercase values for each of the 52 possible letters (26 * 2 cases (upper and lower))
        for (int i = 0; i <= 25; i++)
        {
            keyValueDict.Add(lowerAlphabet[i], keyLower[i]);
            keyValueDict.Add(upperAlphabet[i], keyUpper[i]);
        }

        foreach(char ch in plaintext)
        {
            char newCh = keyValueDict[ch];
            encodedStr += newCh;
        }

        return encodedStr;
    }
}