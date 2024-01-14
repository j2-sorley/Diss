using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawningLargeWithSmall : MonoBehaviour
{
    public List<Transform> SmallspawnPoints;
    public Transform LargespawnPoints;
    public GameObject[] Items;
    public GameObject[] largeItems;
    public int ItemAmount; 

    // Start is called before the first frame update
    void Start()
    {
        ItemAmount = Random.Range(2, SmallspawnPoints.Count);
        for (int i = 0; i < ItemAmount; i++)
        {
            int b = Random.Range(0, SmallspawnPoints.Count);
            Instantiate(Items[Random.Range(0, Items.Length)], SmallspawnPoints[b].position, SmallspawnPoints[b].rotation);
            SmallspawnPoints.Remove(SmallspawnPoints[b]);
        }

        int L = Random.RandomRange(0, largeItems.Length);
        Instantiate(largeItems[L], LargespawnPoints.position, LargespawnPoints.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
