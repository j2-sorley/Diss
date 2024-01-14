using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawning : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject[] Items;
    public int ItemAmount; 

    // Start is called before the first frame update
    void Start()
    {
        ItemAmount = Random.Range(2, spawnPoints.Count);
        for (int i = 0; i < ItemAmount; i++)
        {
            int b = Random.Range(0, spawnPoints.Count);
            Instantiate(Items[Random.Range(0, Items.Length)], spawnPoints[b].position, spawnPoints[b].rotation);
            spawnPoints.Remove(spawnPoints[b]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
