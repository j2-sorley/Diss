using System.Collections;
using System.Collections.Generic;
using System.Threading; 
using UnityEngine;

public class BathroomGen : MonoBehaviour
{
    [Header("Spawns")]
    public List<Transform> spawnPoints;
    public List<Transform> WallspawnPoints;
    public List<Transform> FloorSpawnPoints;
    public Transform LightSpawnPoint; 

    [Header("Items")]
    public GameObject[] Items;
    private int ItemAmount;
    public GameObject[] WallItems; 
    private int WallItemsAmount;
    public GameObject[] FloorItems;
    private int FloorItemsAmount;
    public GameObject[] Lights;
    // Start is called before the first frame update
    void Start()
    {
        
        // Items Spawning
       ItemAmount = Random.Range(2, spawnPoints.Count);
       for (int i = 0; i < ItemAmount; i++)
        {
            int b = Random.Range(0, spawnPoints.Count); 
            Instantiate(Items[Random.Range(0, Items.Length)], spawnPoints[b].position, spawnPoints[b].rotation);
            spawnPoints.Remove(spawnPoints[b]);
       }
       // Wall Items
       WallItemsAmount = Random.Range(2, WallspawnPoints.Count);
       for (int i = 0; i < WallItemsAmount; i++)
        {
            int b = Random.Range(0, WallspawnPoints.Count);
            Instantiate(WallItems[Random.Range(0, WallItems.Length)], WallspawnPoints[b].position, Quaternion.identity);
            WallspawnPoints.Remove(WallspawnPoints[b]);
        }
       // Floor Items
       FloorItemsAmount = Random.Range(2, FloorSpawnPoints.Count);
       for (int i = 0; i < FloorItemsAmount; i++)
       {
       int b = Random.Range(0, FloorSpawnPoints.Count);
       Instantiate(FloorItems[Random.Range(0, FloorItems.Length)], FloorSpawnPoints[b].position, Quaternion.identity);
       FloorSpawnPoints.Remove(FloorSpawnPoints[b]);
       }
       // Light Object
       Instantiate(Lights[Random.Range(0, Lights.Length)], LightSpawnPoint.position, Quaternion.identity);
             
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
