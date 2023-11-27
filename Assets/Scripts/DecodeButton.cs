using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField shuffletextInputField;
    [SerializeField] TMP_Text outputTextBox;
    
    // TEMPORARILY SERIALIZED:
    [SerializeField] bool BruteForce = false;

    Encoders encoderScript;

    private void Start()
    {
        encoderScript = new Encoders();
    }

    public void OnClick()
    {
        if (!BruteForce)
        {
            int shuffle;
            Int32.TryParse(shuffletextInputField.text, out shuffle);
            string output = encoderScript.ShiftCaesarCipher(plaintextInputField.text, shuffle);

            outputTextBox.text = output;
        }
    }
}