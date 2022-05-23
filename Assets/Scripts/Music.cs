using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public  Slider _Slider;
    
    void Start()
    {
        float value = (float)Data.Get("Music");
        _Slider.value = value;
    }

    public void OnChange(float value)
    {
        Data.Set("Music", value);
        Data.Save();
    }

}
