using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using System.Text.Json;

public static class Data
{
    public const string KEY = "DATA";

    private static AllData _AllData;

    static Data()
    {
        _AllData = Newtonsoft.Json.JsonConvert.DeserializeObject<AllData>(PlayerPrefs.GetString(KEY));
        if (_AllData == null)
        {
            _AllData = new AllData();
        }
    }

    public static void Save()
    {
        PlayerPrefs.SetString(KEY, Newtonsoft.Json.JsonConvert.SerializeObject(_AllData));
    }
    
    public static object Get(string name)
    {
        return _AllData[name];
    } 
    
    public static void Set(string name, object value)
    {
        _AllData[name] = value;
    } 
}

public class AllData
{
    public object this[string propertyName]
    {
        get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
        set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
    }

    public float Sound { get; set; } = 100;
    public float Music { get; set; } = 80;
    public int Graphic { get; set; } = 0;
    public int Language { get; set; } = 0;
}
