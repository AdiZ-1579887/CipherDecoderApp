using System;
using TMPro;
using UnityEngine;

public class DecodeButton : MonoBehaviour
{
    [SerializeField] TMP_InputField plaintextInputField;
    [SerializeField] TMP_InputField shuffletextInputField;
    [SerializeField] TMP_Text outputTextBox;

    Encoders encoderScript;

    private void Start()
    {
        Debug.Log($"DecodeButton on {name}");
        encoderScript = new Encoders();
    }

    public void OnClick()
    {
        int shuffle;
        Int32.TryParse(shuffletextInputField.text, out shuffle);
        string output = encoderScript.ShiftCaesarCipher(plaintextInputField.text, shuffle);

        outputTextBox.text = output;
    }
}