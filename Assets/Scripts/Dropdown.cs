using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdown
{
    public Dropdown()
    {

    }

    [SerializeField] TMP_Dropdown dropDownObject;
    TMP_Text dropDownValue;
    
    void OnValueChanged()
    {
        dropDownValue = dropDownObject.captionText;
    }
}