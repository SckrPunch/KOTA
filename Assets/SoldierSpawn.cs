using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawn : MonoBehaviour
{
    public GameObject prefab;

    public void SpawnSoldier()
    {
        Instantiate(prefab, new Vector3(-7.23f, 2.85f, 0), Quaternion.identity);
    }
}
