using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIndicatorClick : MonoBehaviour
{
    public GameObject PlayerIndicator;
    public GameObject prefab;
    Vector3 colliderPos;
    
    public void soldierSpawner(int spawnPos)
    {
        switch(spawnPos)
        {
            case 1:
                Instantiate(prefab, new Vector3(-7.64f, 3.82f, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab, new Vector3(-7.64f, 1.91f, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab, new Vector3(-7.64f, -0.03f, 0), Quaternion.identity);
                break;
            case 4:
                Instantiate(prefab, new Vector3(-7.64f, -1.96f, 0), Quaternion.identity);
                break;
            case 5:
                Instantiate(prefab, new Vector3(-7.64f, -3.9f, 0), Quaternion.identity);
                break;
            default:
                Debug.Log("Uncaught error");
                break;
        }
    }
    private void OnMouseDown()
    {
        PlayerIndicator.SetActive(false);
        
        
        colliderPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (colliderPos.y >= 3.32 && colliderPos.y <= 4.32)
        {
            soldierSpawner(1);
        }
        else if (colliderPos.y >= 1.41 && colliderPos.y <= 2.41)
        {
            soldierSpawner(2);
        }
        else if (colliderPos.y >= -0.53 && colliderPos.y <= 0.47)
        {
            soldierSpawner(3);
        }
        else if (colliderPos.y >= -2.46 && colliderPos.y <= -1.46)
        {
            soldierSpawner(4);
        }
        else if (colliderPos.y >= -4.4 && colliderPos.y <= -3.4)
        {
            soldierSpawner(5);
        }
    }
}
