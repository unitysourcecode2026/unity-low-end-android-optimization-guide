using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolExample : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int initialPoolSize = 20;

    private readonly Queue<GameObject> pool = new Queue<GameObject>();

    private void Awake()
    {
        CreateInitialPool();
    }

    private void CreateInitialPool()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject pooledObject = CreateNewObject();
            pool.Enqueue(pooledObject);
        }
    }

    private GameObject CreateNewObject()
    {
        GameObject newObject = Instantiate(prefab);
        newObject.SetActive(false);

        return newObject;
    }

    public GameObject GetObject()
    {
        GameObject pooledObject;

        if (pool.Count > 0)
        {
            pooledObject = pool.Dequeue();
        }
        else
        {
            pooledObject = CreateNewObject();
        }

        pooledObject.SetActive(true);

        return pooledObject;
    }

    public void ReturnObject(GameObject objectToReturn)
    {
        if (objectToReturn == null)
            return;

        objectToReturn.SetActive(false);
        pool.Enqueue(objectToReturn);
    }
}
