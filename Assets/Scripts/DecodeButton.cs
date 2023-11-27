using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField shuffletextInputField;
    [SerializeField] TMP_Text outputTextBox;
    
    // TEMPORARILY SERIALIZED FOR TESTING:
    [SerializeField] bool BruteForce = false;

    Encoders encoder;
    BruteForce bruteForcer;

    private void Start()
    {
        encoder = new Encoders();
        bruteForcer = new BruteForce();
    }

    public void OnClick()
    {
        if (BruteForce)
        {
            bruteForcer.CaesarCipher(plaintextInputField.text);
        }
        else
        {
            int shuffle;
            if (!Int32.TryParse(shuffletextInputField.text, out shuffle))
            {
                outputTextBox.text = "Invalid shuffle. Please enter a numeric digit.";
                return;
            }

            string output = encoder.ShiftCaesarCipher(plaintextInputField.text, shuffle);

            outputTextBox.text = output;
        }
    }
}