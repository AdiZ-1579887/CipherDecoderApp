using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DropDown : MonoBehaviour
{
    string[] dropdownOptions = { "Select", "Caesar", "Monoalphabetic", "Rot13" };
    public string selectedOption = "Select";

    public void OnValueChanged(int index)
    {
        selectedOption = dropdownOptions[index];
    }
}