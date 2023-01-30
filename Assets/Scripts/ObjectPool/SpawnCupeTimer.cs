using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    // Objeyi ne kadar sıklıkla çağırıcaz?
    [SerializeField] private float spawnInterval = 1;
    [SerializeField] private ObjectPool objectPool = null;

    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    private IEnumerator SpawnRoutine()
    {
        int test = 0; 
        while (true) // Sonsuz Döngü
        {
            // Bir sphere objesini bir de cupe objesini çağır
            GameObject obj = objectPool.GetPooledObject(test++ % 2);
            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
