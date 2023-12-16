using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    #region Serialized Objects
    // InputField and TextBox objects are linked to from here
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField secondaryInputField;
    [SerializeField] TMP_Text outputTextBox;
    
    // TEMPORARILY SERIALIZED FOR TESTING (will eventually be a checkbox in the application itself, or there may be a dedicated, separate Brute-Force menu):
    [SerializeField] bool BruteForce = false;

    // Serialized scripts
    [SerializeField] DropdownMenu dropdownMenu;
    #endregion

    Encoders encoder;
    BruteForce bruteForcer;

    private void Start()
    {
        encoder = new Encoders();
        bruteForcer = new BruteForce();
    }
    
    public void OnClick()
    {
        // Grabs the selected option from the dropdown object's script
        string selectedOption = dropdownMenu.selectedOption;

        // Each case will set the output variables, which the text box that contains the result will display after the switch statement ends
        string output = "";
        string plaintext = plaintextInputField.text;

        #region selectedOption Switch Statement
        switch (selectedOption)
        {
            // If the user either hasn't changed the dropdown or has changed it, but they chose "Select a Cipher"
            case "Select":
                output = "Please select a cipher.";
                break;

            case "Caesar":
                // If the user has checked the 'Brute-Force' checkbox (yet to be added) 
                if (BruteForce)
                {
                    bruteForcer.CaesarCipher(plaintext);
                    // MUST ADD SUPPORT FOR DICTIONARY OUTPUT
                }
                else
                {
                    if (!Int32.TryParse(secondaryInputField.text, out int shuffle))
                    {
                        output = "Invalid shuffle. Please enter a numeric digit.";
                        break;
                    }

                    output = encoder.CaesarCipher(plaintext, shuffle);
                }
                break;

            case "Monoalphabetic":
                if (BruteForce)
                {
                    bruteForcer.MonoalphabeticCipher(plaintext);
                    // MUST ADD SUPPORT FOR DICTIONARY OUTPUT
                }
                else
                {
                    output = encoder.MonoalphabeticCipher(plaintext, secondaryInputField.text);
                }
                break;

            case "Rot13":
                // Decoding with the Rot13 cipher is the same as just encoding the encoded text again
                output = encoder.Rot13Cipher(plaintext);
                break;

            case "Reverse":
                output = encoder.ReverseText(plaintext);
                break;
            case "Morse":
                output = encoder.MorseCode(plaintext);
                break;
                
                // For if the dropdown text is not one of the available ciphers, though this should not be possible
            default:
                output = "The dropdown selection caused an error. Please try again.";
                break;
        }
        #endregion

        outputTextBox.text = output;
    }
}