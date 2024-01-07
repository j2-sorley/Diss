using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public Transform[] spawnPoints; 
    public GameObject[] Items;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++) 
        {
            Instantiate(Items[Random.Range(0,Items.Length)], spawnPoints[i].position,Quaternion.identity );
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
