using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropDownObject;
    TMP_Text dropDownValue;
    
    public void OnValueChanged(int index)
    {
        dropDownValue = dropDownObject.captionText;
    }
}