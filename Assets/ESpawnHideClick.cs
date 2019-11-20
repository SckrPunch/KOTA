using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawnHideClick : MonoBehaviour
{
    public GameObject SpawnIndicator;
    public void showSpawn()
    {
        //Debug.Log(SpawnIndicator.activeSelf);

        if (SpawnIndicator.activeSelf == false)
        {
            SpawnIndicator.SetActive(true);
        }
        else
        {
            SpawnIndicator.SetActive(false);
        }
    }
}
