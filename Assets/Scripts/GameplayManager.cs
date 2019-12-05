using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private int spawnType;
    private int soldierTimerEnable;
    private int workerTimerEnable;
    public float soldierTime;
    public float workerTime;
    
    public void WorkerSelector()
    {
        spawnType = 0;
        //Debug.Log(spawnType);
    }

    public void SoldierSelector()
    {
        spawnType = 1;
        //Debug.Log(spawnType);
    }

    public void EnableSoldierTimer()
    {
        soldierTimerEnable = 1;
    }

    public void EnableWorkerTimer()
    {
        workerTimerEnable = 1;
    }

    private void ResetSoldierTimer()
    {
        soldierTime = 10f;
    }

    private void ResetWorkerTimer()
    {
        workerTime = 5f;
    }

    public int GetUnitSpawn()
    {
        return spawnType;
    }

    private void Update()
    {
        if(soldierTimerEnable == 1)
        {
            soldierTime -= Time.deltaTime;
        }

        if(workerTimerEnable == 1)
        {
            workerTime -= Time.deltaTime;
        }
    }
}
