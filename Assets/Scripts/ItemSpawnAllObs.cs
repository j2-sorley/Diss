using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnAllObs : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject[] Items;
    

    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            
            Instantiate(Items[Random.Range(0, Items.Length)], spawnPoints[i].position, spawnPoints[i].rotation);
            spawnPoints.Remove(spawnPoints[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
