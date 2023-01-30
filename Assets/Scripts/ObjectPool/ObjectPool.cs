using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //Farklı objeleri üretmek için birden fazla object pool gerekli ve
    //pool yapılarını array içine atabilmek için struct yapısını kullanmak gerek.
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab; // Prefab'da bulunan obje
        public int poolSize;  // Kaç adet obje bu havuzda saklanacak
    }
    [SerializeField] private Pool[] pools = null;
    private void Awake()
    {
        //Kaç tane havuz var ise ona göre for döngüsü kullan
        for (int j = 0; j < pools.Length; j++) //Kaç tane havuz var ise tekrar tekrar yap
        {
            pools[j].pooledObjects = new Queue<GameObject>(); // j. havuz kaçıncı havuz ise 
            // 0 numaralı havuzda poolSize ne kadar olacaksa o kadar kez işlemi tekrarla 
            for (int i = 0; i < pools[j].poolSize; i++)
            {
                // 0 numaralı pool'un prefab'i ne ise ondan oluştur
                GameObject obj = Instantiate(pools[j].objectPrefab); 
                obj.SetActive(false); // Obje kapalı
                pools[j].pooledObjects.Enqueue(obj); //Sıraya ekle
            }
        }
    }
    // Her zaman bir tane (sıranın en başından) nesne alınıyor ve o nesne  sıradan çıkmış oluyor.
    // İkinci sıradaki obje bir'e geliyor ve bu şekilde kayıyor, 
    // Yani sıranın sonuna ekleme yapıp sıranın başından alabiliyoruz.
    // GetPooledObject fonksiyonu çağırıldığı anda sıranın en başındakini alıyoruz.
    public GameObject GetPooledObject(int objectType)
    {
        // Havuz sayısı kendi sayısından fazla verilirse null çevir
        if (objectType >= pools.Length) 
        {
            return null;
        }
        GameObject obj = pools[objectType].pooledObjects.Dequeue();
        obj.SetActive(true); // Obje çağırıldığı için objeyi açmamız lazım.
        // Objeyi tekrar çağırmak için sıranın sonuna eklendi
        pools[objectType].pooledObjects.Enqueue(obj); 
        return obj;
    }
}
