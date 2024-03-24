using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayOneGen : MonoBehaviour
{
    public List<Transform> largeRoomLocations;
    public List<Transform> smallRoomLocations;
    public List<Transform> HallwayExitOne;
    public List<Transform> HallwayExitTwo;
    public List<GameObject> Hallways;
    public GameObject Room;
    public GameObject[] SmallRoom;
    public GameObject CollisonOneBox;
    public GameObject CollisonTwoBox;
    public bool ExitOneBlockedBool;
    public bool ExitTwoBlockedBool;



    // Start is called before the first frame update
    void Start()
    {
        int v = Random.Range(1, 3); 
                StartCoroutine(Delay());
        IEnumerator Delay() { yield return new WaitForSecondsRealtime(v); RoomOne();  }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ExitOneBlocked() { ExitOneBlockedBool = true; }
    public void ExitTwoBlocked() { ExitTwoBlockedBool = true; }



    public void RoomOne()
    {
        int a = Random.Range(0, 100);
        if (a > 90)
        {
            Instantiate(SmallRoom[Random.Range(0, SmallRoom.Length)], smallRoomLocations[0].position, smallRoomLocations[0].rotation);

        }

        else
        {
            Instantiate(Room, largeRoomLocations[0].position, largeRoomLocations[0].rotation);
        }

        RoomTwo();

    }

    void RoomTwo()
    {
        int b = Random.Range(0, 100);
        if (b > 90)
        {
            Instantiate(SmallRoom[Random.Range(0, SmallRoom.Length)], smallRoomLocations[1].position, smallRoomLocations[1].rotation);
        }
        else
        {
            Instantiate(Room, largeRoomLocations[1].position, largeRoomLocations[1].rotation);
        }
        RoomThree();

    }

    void RoomThree()
    {
        int C = Random.Range(0, 100);
        if (C > 90)
        {
            Instantiate(SmallRoom[Random.Range(0, SmallRoom.Length)], smallRoomLocations[2].position, smallRoomLocations[2].rotation);

        }
        else
        {
            Instantiate(Room, largeRoomLocations[2].position, largeRoomLocations[2].rotation);
        }
        RoomFour();

    }

    void RoomFour()
    {
        int D = Random.Range(0, 100);
        if (D > 90)
        {
            Instantiate(SmallRoom[Random.Range(0, SmallRoom.Length)], smallRoomLocations[3].position, smallRoomLocations[3].rotation);
        }
        else
        {
            Instantiate(Room, largeRoomLocations[3].position, largeRoomLocations[3].rotation);
        }

        HallwayOne();

    }

    void HallwayOne()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();

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

    void HallwayTwo()
    {
        var Gen = GameObject.Find("Generation Controller").GetComponent<GenController>();

        if (Gen.MoreHallways)
        {
            if (!ExitTwoBlockedBool)
            {
                int l = Random.Range(0, HallwayExitTwo.Count);
                Instantiate(Hallways[l], HallwayExitTwo[l].position, HallwayExitTwo[l].rotation);
                Gen.HallwayIntAdd();
            }
        }

    }

    
}
