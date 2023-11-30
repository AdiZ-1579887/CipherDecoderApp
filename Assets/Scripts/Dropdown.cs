using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dropdown : MonoBehaviour
{
    string[] dropdownOptions = { "Select", "Caesar", "Mono-alphabetic", "Rot13" };
    public string selectedOption = "Select";

    public void OnValueChanged(int index)
    {
        selectedOption = dropdownOptions[index];
    }
}