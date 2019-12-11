using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAI : MonoBehaviour
{
    public GameObject WorkerPrefab;
    public GameObject SoldierPrefab;
    //public float spawnDelay;

    private GameObject detector1;
    private GameObject detector2;
    private GameObject detector3;
    private GameObject detector4;
    private GameObject detector5;
    private GameObject gameplayManager;
    private string antpos1;
    private string antpos2;
    private string antpos3;
    private string antpos4;
    private string antpos5;
    private string antposTotal;
    //private bool recentSpawn;
    

    private void Start()
    {
        detector1 = GameObject.Find("Detector1");
        detector2 = GameObject.Find("Detector2");
        detector3 = GameObject.Find("Detector3");
        detector4 = GameObject.Find("Detector4");
        detector5 = GameObject.Find("Detector5");
        gameplayManager = GameObject.Find("Gameplay Manager");
        //recentSpawn = false;
    }
    private void FixedUpdate()
    {
        bool pos1 = detector1.GetComponent<Detector1>().CheckLane();
        bool pos2 = detector2.GetComponent<Detector2>().CheckLane();
        bool pos3 = detector3.GetComponent<Detector3>().CheckLane();
        bool pos4 = detector4.GetComponent<Detector4>().CheckLane();
        bool pos5 = detector5.GetComponent<Detector5>().CheckLane();


        if (pos1 == true)
        {
            antpos1 = "1";
        }
        else
        {
            antpos1 = "0";
        }
        if (pos2 == true)
        {
            antpos2 = "1";
        }
        else
        {
            antpos2 = "0";
        }
        if (pos3 == true)
        {
            antpos3 = "1";
        }
        else
        {
            antpos3 = "0";
        }
        if (pos4 == true)
        {
            antpos4 = "1";
        }
        else
        {
            antpos4 = "0";
        }
        if (pos5 == true)
        {
            antpos5 = "1";
        }
        else
        {
            antpos5 = "0";
        }

        antposTotal = antpos1 + antpos2 + antpos3 + antpos4 + antpos5;
    }
    public void UnitSpawner(int unitType, int spawnPos)
    {
        Debug.Log(unitType);
        Debug.Log(spawnPos);
        switch (unitType)
        {
            case 0:
                switch (spawnPos)
                {
                    case 1:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, 3.82f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 2:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, 1.91f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 3:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -0.03f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 4:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -1.96f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 5:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -3.9f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    default:
                        Debug.Log("Uncaught error with spawn location");
                        break;
                }
                break;
            case 1:
                switch (spawnPos)
                {
                    case 1:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, 3.82f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 2:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, 1.91f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 3:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -0.03f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 4:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -1.96f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    case 5:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -3.9f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        //recentSpawn = true;
                        break;
                    default:
                        Debug.Log("Uncaught error with spawn location");
                        break;
                }
                break;
            default:
                Debug.Log("Uncaught error with unit type");
                break;
        }

    }

    private void Update()
    {
        int workers = gameplayManager.GetComponent<GameplayManager>().ReturnWorkerSpawns();
        int soldiers = gameplayManager.GetComponent<GameplayManager>().ReturnSoldierSpawns();
        int spawnposW = Random.Range(1,6);
        int spawnposS = Random.Range(1,6);

        /*if (recentSpawn == true)
        {
            spawnDelay -= Time.deltaTime;
        }*/

        switch(antposTotal)
        {
            case "00000":
                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00001":
                if(spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if(soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00010":
                if (spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00011":
                if (spawnposW == 5 || spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 5 || spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00100":
                if (spawnposW == 3)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 3);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00101":
                if (spawnposW == 3 || spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 3 || spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00110":
                if (spawnposW == 3 || spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 3 || spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "00111":
                if (spawnposW == 3 || spawnposW == 4 || spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 3 || spawnposW == 4 || spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01000":
                if (spawnposW == 2)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01001":
                if (spawnposW == 2 || spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01010":
                if (spawnposW == 2 || spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01011":
                if (spawnposW == 2 || spawnposW == 4 || spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 4 || spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01100":
                if (spawnposW == 2 || spawnposW == 3)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 3);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01101":
                if (spawnposW == 2 || spawnposW == 3 || spawnposW == 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 3 || spawnposW == 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01110":
                if (spawnposW == 2 || spawnposW == 3 || spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 2 || spawnposW == 3 || spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "01111":
                spawnposW = 1;
                spawnposS = 1;

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10000":
                if (spawnposW == 1)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 1);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10001":
                if (spawnposW == 5 || spawnposW == 1)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 5 || spawnposW == 1);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10010":
                if (spawnposW == 1 || spawnposW == 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 1 || spawnposW == 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10011":
                if (spawnposW != 2 && spawnposW != 3)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 2 && spawnposW != 3);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10100":
                if (spawnposW == 1 || spawnposW == 3)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 1 || spawnposW == 3);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10101":
                if (spawnposW != 2 && spawnposW != 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 2 && spawnposW != 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10110":
                if (spawnposW != 2 && spawnposW != 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 2 && spawnposW != 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "10111":
                spawnposW = 2;

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11000":
                if (spawnposW == 1 || spawnposW == 2)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW == 1 || spawnposW == 2);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11001":
                if (spawnposW != 3 && spawnposW != 4)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 3 && spawnposW != 4);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11010":
                if (spawnposW != 3 && spawnposW != 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 3 && spawnposW != 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11011":
                spawnposW = 3;

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11100":
                if (spawnposW != 4 && spawnposW != 5)
                {
                    do
                    {
                        spawnposW = Random.Range(1, 6);
                    }
                    while (spawnposW != 4 && spawnposW != 5);
                }

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11101":
                spawnposW = 4;

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11110":
                spawnposW = 5;

                if (workers > 0)
                {
                    UnitSpawner(0, spawnposW);
                    break;
                }
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            case "11111":
                if (soldiers > 0)
                {
                    UnitSpawner(1, spawnposS);
                    break;
                }
                break;
            default:
                Debug.Log("Uncaught AI error");
                break;
        }
    }
}
