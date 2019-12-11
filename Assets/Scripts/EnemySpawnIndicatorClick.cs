using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnIndicatorClick : MonoBehaviour
{
    public GameObject EnemyIndicator;
    public GameObject WorkerPrefab;
    public GameObject SoldierPrefab;
    private GameObject gameplayManager;
    public static int count = 0;

    Vector3 colliderPos;

    private void Start()
    {
        gameplayManager = GameObject.Find("Gameplay Manager");
    }

    public void UnitSpawner(int unitType, int spawnPos)
    {
        switch (unitType)
        {
            case 0:
                switch (spawnPos)
                {
                    case 1:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, 3.82f, 0), Quaternion.Euler(0, 0, 180));
                        count = 1;
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 2:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, 1.91f, 0), Quaternion.Euler(0, 0, 180));
                        count = 1;
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 3:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -0.03f, 0), Quaternion.Euler(0, 0, 180));
                        count = 1;
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 4:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -1.96f, 0), Quaternion.Euler(0, 0, 180));
                        count = 1;
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 5:
                        Instantiate(WorkerPrefab, new Vector3(7.428f, -3.9f, 0), Quaternion.Euler(0, 0, 180));
                        count = 1;
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
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
                        break;
                    case 2:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, 1.91f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 3:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -0.03f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 4:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -1.96f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
                        break;
                    case 5:
                        Instantiate(SoldierPrefab, new Vector3(7.428f, -3.9f, 0), Quaternion.Euler(0, 0, 180));
                        gameplayManager.GetComponent<GameplayManager>().UseSpawn(unitType, 1);
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
    private void OnMouseDown()
    {
        EnemyIndicator.SetActive(false);
        int st = gameplayManager.GetComponent<GameplayManager>().GetUnitSpawnE();
        bool spawnPossible = gameplayManager.GetComponent<GameplayManager>().CheckSpawn(st, 1);



        colliderPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (colliderPos.y >= 3.32 && colliderPos.y <= 4.32 && spawnPossible)
        {
            UnitSpawner(st, 1);
            gameplayManager.GetComponent<GameplayManager>().UseSpawn(st, 1);
        }
        else if (colliderPos.y >= 1.41 && colliderPos.y <= 2.41 && spawnPossible)
        {
            UnitSpawner(st, 2);
            gameplayManager.GetComponent<GameplayManager>().UseSpawn(st, 1);
        }
        else if (colliderPos.y >= -0.53 && colliderPos.y <= 0.47 && spawnPossible)
        {
            UnitSpawner(st, 3);
            gameplayManager.GetComponent<GameplayManager>().UseSpawn(st, 1);
        }
        else if (colliderPos.y >= -2.46 && colliderPos.y <= -1.46 && spawnPossible)
        {
            UnitSpawner(st, 4);
            gameplayManager.GetComponent<GameplayManager>().UseSpawn(st, 1);
        }
        else if (colliderPos.y >= -4.4 && colliderPos.y <= -3.4 && spawnPossible)
        {
            UnitSpawner(st, 5);
            gameplayManager.GetComponent<GameplayManager>().UseSpawn(st, 1);
        }
    }
}
