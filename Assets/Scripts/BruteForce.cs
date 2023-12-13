using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using System.Linq;

public class BruteForce
{
    readonly IList<char> upperAlphabet;
    readonly IList<char> lowerAlphabet;
    readonly List<char> frequencyOrderedAlphabet = new() { 'e', 't', 'a', 'o', 'i', 'n', 's', 'h', 'r', 'd', 'l', 'c', 'u', 'm', 'w', 'f', 'g', 'y', 'p', 'b', 'v', 'k', 'j', 'x', 'q', 'z' };

    Encoders encoder;

    // Constructor
    public BruteForce()
    {
        upperAlphabet = ConstantVars.upperAlphabet;
        lowerAlphabet = ConstantVars.lowerAlphabet;
        encoder = new();
    }

    string RemoveSpecialCharacters(string s)
    {
        // Returns a string in which 0-9, A-Z, a-z, and ' ' are allowed, but everything else is removed.
        return Regex.Replace(s, "[^0-9A-Za-z ]", "");
    }

    string RemoveDigits(string s)
    {
        return Regex.Replace(s, "[^A-Za-z ]", "");
    }

    // Function will return each decoded string alongside its score in terms of how many English words were found in it
    public Dictionary<string, int> CaesarCipher(string encodedStr)
    {
        Dictionary<string, int> dict = new();

        if (string.IsNullOrEmpty(encodedStr))
        {
            return dict;
        }

        // Find the index of the most common char (letters only) in the array lowerAlphabet
        char frequentLetter = Char.ToLower(RemoveDigits(encodedStr).GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key);
        int frequentLetterIndex = Array.IndexOf(lowerAlphabet.ToArray(), frequentLetter);
        for (int i = 0; i <= 5; i++)
        {
            // Find the index of the char from frequencyOrderedAlphabet that we are using for this run of the loop
            char letter = frequencyOrderedAlphabet[i];
            int letterIndex = Array.IndexOf(lowerAlphabet.ToArray(), letter);

            // Find the difference by which the encoded string must be shuffled to be decoded
            int difference = letterIndex - frequentLetterIndex;

            string tempStr = encoder.CaesarCipher(encodedStr, difference);
            int score = 0;

            // CHECK HOW MANY ENGLISH WORDS ARE IN STRING

            dict.Add(tempStr, score);
        }

        return dict;
    }

    public Dictionary<string, int> MonoalphabeticCipher(string encodedStr)
    {
        Dictionary<string, int> dict = new();

        if (string.IsNullOrEmpty(encodedStr))
        {
            return dict;
        }

        // BRUTE-FORCE THE MONOALPHABETIC CIPHER
        
        return dict;
    }

    public Dictionary<string, int> Rot13Cipher(string encodedStr)
    {
        Dictionary<string, int> dict = new();

        if (string.IsNullOrEmpty(encodedStr))
        {
            return dict;
        }

        // BRUTE-FORCE THE ROT13 CIPHER

        return dict;
    }
}