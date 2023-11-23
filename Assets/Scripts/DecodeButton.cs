using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField shuffletextInputField;

    Decoders decoderScript;

    void Awake()
    {
        
    }

    public void OnClick()
    {
        // int shuffle;
        Debug.Log(plaintextInputField.text);
        // Int32.TryParse(shuffleStringInput.input, out shuffle);
        // string output = decoderScript.CaesarCipher(plaintextStringInput.input, shuffle);
    }
}