using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayTwoGen : MonoBehaviour
{

    public List<Transform> largeRoomLocations;
    public List<Transform> HallwayExitOne;
    public List<Transform> HallwayExitTwo;
    public List<Transform> HallwayExitThree;
    public List<Transform> HallwayExitFour;
    public List<GameObject> Hallways;
    public GameObject Room;
    public bool ExitOneBlockedBool;
    public bool ExitTwoBlockedBool;
    public bool ExitThreeBlockedBool;
    public bool ExitFourBlockedBool;

    [Header("Mats")]
    public Material[] WallMats;
    public Material[] FloorMats;
    public Material[] RoofMats;

    [Header("Walls")]
    public Renderer[] Walls;
    public Renderer[] Floors;
    public Renderer[] Roof;

    void Start()
    {
        int W = Random.Range(0, WallMats.Length);
        for (int j = 0; j < Walls.Length; j++) { Walls[j].material = WallMats[W]; }

        int f = Random.Range(0, FloorMats.Length);
        for (int j = 0; j < Floors.Length; j++) { Floors[j].material = FloorMats[f]; }

        int R = Random.Range(0, RoofMats.Length);
        for (int j = 0; j < Roof.Length; j++) { Roof[j].material = RoofMats[R]; }

        int v = Random.Range(1, 3); 
        StartCoroutine(Delay());
        IEnumerator Delay() { yield return new WaitForSecondsRealtime(v); RoomOne(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitOneBlocked() { ExitOneBlockedBool = true;}
    public void ExitTwoBlocked() { ExitTwoBlockedBool = true;}
    public void ExitThreeBlocked() {  ExitThreeBlockedBool = true;}
    public void ExitFourBlocked() {  ExitFourBlockedBool = true;}

    public void RoomOne()
    {
        

       
        
            Instantiate(Room, largeRoomLocations[0].position, largeRoomLocations[0].rotation);
        

        RoomTwo();

    }

    void RoomTwo()
    {
        
            Instantiate(Room, largeRoomLocations[1].position, largeRoomLocations[1].rotation);
        
        RoomThree();

    }

    void RoomThree()
    {
        
        
            Instantiate(Room, largeRoomLocations[2].position, largeRoomLocations[2].rotation);
        
        RoomFour();

    }

    void RoomFour()
    {
        
            Instantiate(Room, largeRoomLocations[3].position, largeRoomLocations[3].rotation);
        

        HallwayOne();

    }

    void HallwayOne()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();

        StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSecondsRealtime(1);

            if (Gen.MoreHallways)
            {
                if (!ExitOneBlockedBool)
                {

                    int i = Random.Range(0, HallwayExitOne.Count);
                    Instantiate(Hallways[i], HallwayExitOne[i].position, HallwayExitOne[i].rotation);
                    Gen.HallwayIntAdd();
                }
            }

            HallwayTwo();
        }
    }

    void HallwayTwo()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();

        StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSecondsRealtime(1);

            if (Gen.MoreHallways)
            {
                if (!ExitTwoBlockedBool)
                {

                    int i = Random.Range(0, HallwayExitTwo.Count);
                    Instantiate(Hallways[i], HallwayExitTwo[i].position, HallwayExitTwo[i].rotation);
                    Gen.HallwayIntAdd();
                }
            }

            HallwayThree();
        }
    }

    void HallwayThree()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();
        StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSecondsRealtime(1);

            if (Gen.MoreHallways)
            {
                if (!ExitThreeBlockedBool)
                {

                    int i = Random.Range(0, HallwayExitThree.Count);
                    Instantiate(Hallways[i], HallwayExitThree[i].position, HallwayExitThree[i].rotation);
                    Gen.HallwayIntAdd();
                }
            }

            HallwayFour();
        }
    }

    void HallwayFour()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();

        StartCoroutine(Delay());
        IEnumerator Delay()
        {
            yield return new WaitForSecondsRealtime(1);

            if (Gen.MoreHallways)
            {
                if (!ExitFourBlockedBool)
                {

                    int i = Random.Range(0, HallwayExitFour.Count);
                    Instantiate(Hallways[i], HallwayExitFour[i].position, HallwayExitFour[i].rotation);
                    Gen.HallwayIntAdd();
                }
           }

        }
    }
}
