using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using static Decoders;
using static ListConstants;
using Unity.Collections.LowLevel.Unsafe;
using System.Linq;

public class BruteForceDecoder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Decoders decoder = new Decoders();
        ListConstants listConstants = new ListConstants();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string RemoveSpecialCharacters(string s)
    {
        // Returns a string in which 0-9, A-Z, a-z, and ' ' are allowed, but everything else is removed.
        return Regex.Replace(s, "[^0-9A-Za-z ]", "");
    }

    void BruteForceCaesarCipher(string encodedStr, Decoders decoder, ListConstants listConstants)
    {
        if (string.IsNullOrEmpty(encodedStr))
        {
            return;
        }

        // shuffleScore keeps track of what int shuffle gives the best performance - ranked on how many occurances of a tenKMostCommonWord(s) (ListConstants.cs) there is.
        var shuffleScore = new Dictionary<int, int>();
        // arrOfWords stores a string[] of all the words in the encoded string
        string[] arrOfWords = RemoveSpecialCharacters(encodedStr).Split(" ");

        // We must loop over words in string and compare with common words from ListConstants.cs
        // Grabbing commonWords string[] from ListConstants.cs here
        Dictionary<int, HashSet<string>> commonWords = listConstants.commonWordsDICT;

        // Implement a for loop between 0 (in case it is already decoded) and 26 and call Decoders.CaesarCipher() to evaluate.
        for(int i = 0; i <= 26; i++)
        {
            // The number of words which are found in the commonWords list.
            int score = 0;

            foreach(string word in arrOfWords)
            {
                if (commonWords[word.Length].Contains(decoder.CaesarCipher(word, i)))
                {
                    score++;
                }

            }
        }
    }
}