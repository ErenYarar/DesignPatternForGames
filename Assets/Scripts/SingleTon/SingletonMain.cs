using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMain : MonoBehaviour
{
    private void Start() 
    {
        GameManager.Instance.num1 = 5;
    }

    private void Update()
    {
        Debug.Log(Singleton.Instance.GetText());
        Debug.Log(GameManager.Instance.num1);
    }
}

// public class SomeClass : MonoBehaviour
// {
//     private volatile bool _isRunning;
//     private void Update()
//     {
//         if (_isRunning)
//         {
//             // Bir şey yap
//         }
//     }
//     public void StartRunning()
//     {
//         _isRunning = true;
//     }
//     public void StopRunning()
//     {
//         _isRunning = false;
//     }
// }
