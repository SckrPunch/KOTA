using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideSpawn : MonoBehaviour
{
    public GameObject SpawnIndicator;
    public void showSpawn()
    {

        if(SpawnIndicator.activeSelf == false)
        {
            SpawnIndicator.SetActive(true);
        }
        else
        {
            SpawnIndicator.SetActive(false);
        }
    }
}
