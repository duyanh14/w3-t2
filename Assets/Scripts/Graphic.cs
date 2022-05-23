using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Graphic : MonoBehaviour
{
    public Dropdown _Dropdown;
    
    void Start()
    {
        _Dropdown = GetComponent<Dropdown>();
        Debug.Log(_Dropdown.value);
        // int value = (int)Data.Get("Graphic");
        // (_Dropdown).value = value;
    }

    public void OnChange(int value)
    {
        Data.Set("Graphic", value);
        Data.Save();
    }

}