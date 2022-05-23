using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public  Slider _Slider;
    
    void Start()
    {
        float value = (float)Data.Get("Sound");
        _Slider.value = value;
    }

    public void OnChange(float value)
    {
        Data.Set("Sound", value);
        Data.Save();
    }

}
