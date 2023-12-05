using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DropDown : MonoBehaviour
{
    [SerializeField] TMP_InputField secondaryInputField;

    string[] dropdownOptions = { "Select", "Caesar", "Monoalphabetic", "Rot13" };
    public string selectedOption;
    readonly Dictionary<string, bool> secondaryInputRequiredDict = new()
    {
        { "Select", false },
        { "Caesar", true },
        { "Monoalphabetic", true },
        { "Rot13", false }
    };

    void Start()
    {
        secondaryInputField.interactable = false;
        selectedOption = "Select";
    }

    public void OnValueChanged(int index)
    {
        selectedOption = dropdownOptions[index];

        // If the selected cipher does not require the use of a secondary input, the secondary input field will be greyed out
        if (secondaryInputRequiredDict[selectedOption])
        {
            secondaryInputField.interactable = true;
        } else
        {
            secondaryInputField.interactable = false;
        }
    }
}