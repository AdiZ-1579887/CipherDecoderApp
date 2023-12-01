using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    // InputField and TextBox objects are linked to from here
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField shuffletextInputField;
    [SerializeField] TMP_Text outputTextBox;
    
    // TEMPORARILY SERIALIZED FOR TESTING:
    [SerializeField] bool BruteForce = false;

    Encoders encoder;
    BruteForce bruteForcer;
    Dropdown dropdown;

    private void Start()
    {
        encoder = new Encoders();
        bruteForcer = new BruteForce();
        dropdown = new Dropdown();

    }
    
    public void OnClick()
    {
        // Grabs the selected option from the dropdown object's script
        string selectedOption = dropdown.selectedOption;

        // Each case will set the output variables, which the text box that contains the result will display after the switch statement ends
        string output = "";
        switch (selectedOption)
        {
            // If the user either hasn't changed the dropdown or has changed it, but they chose "Select a Cipher"
            case "Select":
                output = "Please select a cipher.";
                break;

            case "Caesar":
                // If the user has checked the 'Brute-Force' checkbox (yet to be added), t
                if (BruteForce)
                {
                    bruteForcer.CaesarCipher(plaintextInputField.text);
                    // MUST ADD SUPPORT FOR DICTIONARY OUTPUT
                }
                else
                {
                    if (!Int32.TryParse(shuffletextInputField.text, out int shuffle))
                    {
                        output = "Invalid shuffle. Please enter a numeric digit.";
                        break;
                    }

                    output = encoder.ShiftCaesarCipher(plaintextInputField.text, shuffle);
                }
                break;

            case "Monoalphabetic":
                if (BruteForce)
                {
                    bruteForcer.MonoalphabeticCipher(plaintextInputField.text);
                    // MUST ADD SUPPORT FOR DICTIONARY OUTPUT
                }
                else
                {
                    output = encoder.MonoalphabeticCipher(plaintextInputField.text, shuffletextInputField.text);
                }
                break;

            case "Rot13":
                // Decoding with the Rot13 cipher is the same as just encoding the encoded text again
                output = encoder.Rot13Cipher(plaintextInputField.text);
                break;

            // For if the dropdown text is not one of the available ciphers, though this should not be possible
            default:
                output = "The dropdown selection caused an error. Please try again.";
                break;
        }

        outputTextBox.text = output;
    }
}