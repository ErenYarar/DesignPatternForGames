using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObject : MonoBehaviour
{
    public static int movespeed = 2;
    public Vector3 movementDirection;
    private void Start()
    {
        movementDirection = new Vector3(1, 0, 0);
    }
    void Update()
    {
        transform.position += movementDirection * movespeed * Time.deltaTime;
    }
}
