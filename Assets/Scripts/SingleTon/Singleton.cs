using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour 
{
    // static instance of GameManager
    public static Singleton instance = null;
    private string text;
    public static Singleton Instance
    {
        get  //bize çevrilecek olan durum
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<Singleton>();
            }
            return instance;
        }
    }
    private void OnEnable()
    {
        instance = this;
        text = "Eren Yarar";
    }
    public string GetText()
    {
        return text;
    }
}
