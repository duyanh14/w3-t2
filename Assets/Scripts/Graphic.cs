using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Graphic : MonoBehaviour
{
    public TMP_Dropdown  _Dropdown;
    
    void Start()
    {
        int value = (int)Data.Get("Graphic");
        _Dropdown.value = value;
    }

    public void OnChange(int value)
    {
        Data.Set("Graphic", value);
        Data.Save();
    }

}