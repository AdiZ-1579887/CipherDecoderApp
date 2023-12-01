using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dropdown
{
    string[] dropdownOptions = { "Select", "Caesar", "Monoalphabetic", "Rot13" };
    public string selectedOption = "Select";

    public void OnValueChanged(int index)
    {
        selectedOption = dropdownOptions[index];
    }
}