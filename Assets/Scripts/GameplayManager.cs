using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    private int spawnTypeP;
    private int spawnTypeE;
    private int workerCountP;
    private int soldierCountP;
    private int workerCountE;
    private int soldierCountE;
    private float workerTimer;
    private float soldierTimer;

    public int soldierMax;
    public int workerMax;
    public float soldierTime;
    public float workerTime;
    public Text soldierTextP;
    public Text workerTextP;
    public Text soldierTextE;
    public Text workerTextE;
    
    public void WorkerSelectorP()
    {
        spawnTypeP = 0;
    }

    public void SoldierSelectorP()
    {
        spawnTypeP = 1;
    }

    public void WorkerSelectorE()
    {
        spawnTypeE = 0;
    }

    public void SoldierSelectorE()
    {
        spawnTypeE = 1;
    }

    public int GetUnitSpawnP()
    {
        return spawnTypeP;
    }

    public int GetUnitSpawnE()
    {
        return spawnTypeE;
    }

    public bool CheckSpawn(int spwnType, int plyrCheck)
    {
        switch(plyrCheck)
        {
            case 0:
                switch (spwnType)
                {
                    case 0:
                        if (workerCountP > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 1:
                        if (soldierCountP > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        Debug.Log("Uncaught spawn check error.");
                        return false;
                }
            case 1:
                switch (spwnType)
                {
                    case 0:
                        if (workerCountE > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 1:
                        if (soldierCountE > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        Debug.Log("Uncaught spawn check error.");
                        return false;
                }
            default:
                Debug.Log("Unhandled spawning player check error");
                return false;
        }
    }

    public void UseSpawn(int st, int plyrCheck)
    {
        switch(plyrCheck)
        {
            case 0:
                switch (st)
                {
                    case 0:
                        workerCountP--;
                        UpdateWorkerTextP();
                        break;
                    case 1:
                        soldierCountP--;
                        UpdateSoldierTextP();
                        break;
                    default:
                        Debug.Log("Uncaught spawn subtraction error");
                        break;
                }
                break;
            case 1:
                switch (st)
                {
                    case 0:
                        workerCountE--;
                        UpdateWorkerTextE();
                        break;
                    case 1:
                        soldierCountE--;
                        UpdateSoldierTextE();
                        break;
                    default:
                        Debug.Log("Uncaught spawn subtraction error");
                        break;
                }
                break;
            default:
                Debug.Log("Unhandled player check error");
                break;
        }
        
    }

    private void UpdateSoldierTextP()
    {
        soldierTextP.text = "Soldier Spawns: " + soldierCountP.ToString();
    }

    private void UpdateWorkerTextP()
    {
        workerTextP.text = "Worker Spawns: " + workerCountP.ToString();
    }

    private void UpdateSoldierTextE()
    {
        soldierTextE.text = "Soldier Spawns: " + soldierCountE.ToString();
    }

    private void UpdateWorkerTextE()
    {
        workerTextE.text = "Worker Spawns: " + workerCountE.ToString();
    }

    private void Update()
    {
        soldierTimer -= Time.deltaTime;
        workerTimer -= Time.deltaTime;

        if (Mathf.Abs(soldierTimer) >= soldierTime)
        {
            soldierTimer = 0f;

            if (soldierCountP < soldierMax)
            {
                soldierCountP++;
                UpdateSoldierTextP();
            }

            if(soldierCountE < soldierMax)
            {
                soldierCountE++;
                UpdateSoldierTextE();
            }
        }

        if (Mathf.Abs(workerTimer) >= workerTime)
        {
            workerTimer = 0f;

            if(workerCountP < workerMax)
            {
                workerCountP++;
                UpdateWorkerTextP();
            }

            if(workerCountP < workerMax)
            {
                workerCountE++;
                UpdateWorkerTextE();
            }
        }
    }
}
