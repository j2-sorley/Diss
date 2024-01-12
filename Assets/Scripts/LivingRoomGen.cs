using System.Collections;
using System.Collections.Generic;
using System.Threading; 
using UnityEngine;

public class LivingRoomGen : MonoBehaviour
{
    [Header("Spawns East Facing")]
    public List<Transform> EastspawnPoints;
    public List<Transform> EastWallspawnPoints;
    public List<Transform> EastFloorSpawnPoints;
    public Transform EastLightSpawnPoint; 
    public Transform EastLargeObjectSpawnPoint;
    public Transform EastFeatureWall;

    [Header("Spawns North Facing")]
    public List<Transform> NorthspawnPoints;
    public List<Transform> NorthWallspawnPoints;
    public List<Transform> NorthFloorSpawnPoints;
    public Transform NorthLightSpawnPoint;
    public Transform NorthLargeObjectSpawnPoint;
    public Transform NorthFeatureWall;

    [Header("Spawns West Facing")]
    public List<Transform> WestspawnPoints;
    public List<Transform> WestWallspawnPoints;
    public List<Transform> WestFloorSpawnPoints;
    public Transform WestLightSpawnPoint;
    public Transform WestLargeObjectSpawnPoint;
    public Transform WestFeatureWall;

    [Header("Items")]
    public GameObject[] Items;
    private int ItemAmount;
    public GameObject[] WallItems; 
    private int WallItemsAmount;
    public GameObject[] FloorItems;
    private int FloorItemsAmount;
    public GameObject[] Lights;
    public GameObject[] LargeObjects; 

    [Header("Walls")]
    public Renderer[] Walls;
    public Renderer Floors;
    public Renderer Roof; 
    
    [Header("Materials")]
    public Material[] WallMats;
    public Material[] FloorMats;
    public Material[] RoofMats;

    private int Direction;
    // Start is called before the first frame update
    void Start()
    {
        Direction = Random.Range(0, 3);
        Debug.Log(Direction);
        if (Direction == 0)
        {
            //EAST
            // Items Spawning
            ItemAmount = Random.Range(2, EastspawnPoints.Count);
            for (int i = 0; i < ItemAmount; i++)
            {
                int b = Random.Range(0, EastspawnPoints.Count);
                Instantiate(Items[Random.Range(0, Items.Length)], EastspawnPoints[b].position, EastspawnPoints[b].rotation);
                EastspawnPoints.Remove(EastspawnPoints[b]);
            }
            // Light Object
            int L = Random.Range(0, Lights.Length);
            Instantiate(Lights[L], EastLightSpawnPoint.position, Quaternion.identity);

            // Wall Items
            WallItemsAmount = Random.Range(2, EastWallspawnPoints.Count);
            for (int i = 0; i < WallItemsAmount; i++)
            {
                int b = Random.Range(0, EastWallspawnPoints.Count);
                Instantiate(WallItems[Random.Range(0, WallItems.Length)], EastWallspawnPoints[b].position, EastWallspawnPoints[b].rotation);
                EastWallspawnPoints.Remove(EastWallspawnPoints[b]);
            }
            // Floor Items
            FloorItemsAmount = Random.Range(2, EastFloorSpawnPoints.Count);
            for (int i = 0; i < FloorItemsAmount; i++)
            {
                int b = Random.Range(0, EastFloorSpawnPoints.Count);
                Instantiate(FloorItems[Random.Range(0, FloorItems.Length)], EastFloorSpawnPoints[b].position, Quaternion.identity);
                EastFloorSpawnPoints.Remove(EastFloorSpawnPoints[b]);
            }

            //large Items
            int Q = Random.Range(0, LargeObjects.Length);
            Instantiate(LargeObjects[Q], EastLargeObjectSpawnPoint.position, EastLargeObjectSpawnPoint.rotation); 
            Debug.Log("East");
        }

        if (Direction==1)
        {
            //West
            // Items Spawning
            ItemAmount = Random.Range(2, WestspawnPoints.Count);
            for (int i = 0; i < ItemAmount; i++)
            {
                int b = Random.Range(0, WestspawnPoints.Count);
                Instantiate(Items[Random.Range(0, Items.Length)], WestspawnPoints[b].position, WestspawnPoints[b].rotation);
                WestspawnPoints.Remove(WestspawnPoints[b]);
            }
            // Light Object
            int L = Random.Range(0, Lights.Length);
            Instantiate(Lights[L], WestLightSpawnPoint.position, Quaternion.identity);

            // Wall Items
            WallItemsAmount = Random.Range(2, WestWallspawnPoints.Count);
            for (int i = 0; i < WallItemsAmount; i++)
            {
                int b = Random.Range(0, WestWallspawnPoints.Count);
                Instantiate(WallItems[Random.Range(0, WallItems.Length)], WestWallspawnPoints[b].position, WestWallspawnPoints[b].rotation);
                WestWallspawnPoints.Remove(WestWallspawnPoints[b]);
            }
            // Floor Items
            FloorItemsAmount = Random.Range(2, WestFloorSpawnPoints.Count);
            for (int i = 0; i < FloorItemsAmount; i++)
            {
                int b = Random.Range(0, WestFloorSpawnPoints.Count);
                Instantiate(FloorItems[Random.Range(0, FloorItems.Length)], WestFloorSpawnPoints[b].position, Quaternion.identity);
                WestFloorSpawnPoints.Remove(WestFloorSpawnPoints[b]);

                
            }
                //large Items
                int Q = Random.Range(0, LargeObjects.Length);
                Instantiate(LargeObjects[Q], WestLargeObjectSpawnPoint.position, WestLargeObjectSpawnPoint.rotation);
                Debug.Log("West");
        }

        if (Direction == 2)
        {
            //North
            // Items Spawning
            ItemAmount = Random.Range(2, NorthspawnPoints.Count);
            for (int i = 0; i < ItemAmount; i++)
            {
                int b = Random.Range(0, NorthspawnPoints.Count);
                Instantiate(Items[Random.Range(0, Items.Length)], NorthspawnPoints[b].position, NorthspawnPoints[b].rotation);
                NorthspawnPoints.Remove(NorthspawnPoints[b]);
            }
            // Light Object
            int L = Random.Range(0, Lights.Length);
            Instantiate(Lights[L], NorthLightSpawnPoint.position, Quaternion.identity);

            // Wall Items
            WallItemsAmount = Random.Range(2, NorthWallspawnPoints.Count);
            for (int i = 0; i < WallItemsAmount; i++)
            {
                int b = Random.Range(0, NorthWallspawnPoints.Count);
                Instantiate(WallItems[Random.Range(0, WallItems.Length)], NorthWallspawnPoints[b].position, NorthWallspawnPoints[b].rotation);
                NorthWallspawnPoints.Remove(NorthWallspawnPoints[b]);
            }
            // Floor Items
            FloorItemsAmount = Random.Range(2, NorthFloorSpawnPoints.Count);
            for (int i = 0; i < FloorItemsAmount; i++)
            {
                int b = Random.Range(0, NorthFloorSpawnPoints.Count);
                Instantiate(FloorItems[Random.Range(0, FloorItems.Length)], NorthFloorSpawnPoints[b].position, Quaternion.identity);
                NorthFloorSpawnPoints.Remove(NorthFloorSpawnPoints[b]);
            }
            //large Items
            int Q = Random.Range(0, LargeObjects.Length);
            Instantiate(LargeObjects[Q], NorthLargeObjectSpawnPoint.position, NorthLargeObjectSpawnPoint.rotation);
            Debug.Log("North");
        }



        // Walls

        int W = Random.Range(0, WallMats.Length);
        for (int j = 0; j < Walls.Length ; j++) { Walls[j].material = WallMats[W]; }

        // Roof 

        int f = Random.Range(0, FloorMats.Length);
        Floors.material = FloorMats[f];

        int R = Random.Range(0, RoofMats.Length);
        Roof.material = RoofMats[R];




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
