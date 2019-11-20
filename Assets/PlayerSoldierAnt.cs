using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoldierAnt : MonoBehaviour
{
    public float speed;
    public GameObject food;
    public GameObject rocket;
    public GameObject rocketContainer;
    private bool fire;

    public bool FireDetect()
    {
        Vector3 soldierPos = transform.position;
        Vector3 foodPos = food.transform.position;
        float furthestDist = -7.23f; //x starting point of player ants
        float foodScale = 0.255f; //x scale
        float soldierScale = 0.75f;
        float percentDist = (Mathf.Abs(soldierPos.x) + soldierScale/2)/ ((foodPos.x - foodScale/2) - furthestDist);
        
        if(percentDist <= 0.5f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool fire = FireDetect();

        if(fire == true)
        {
            Destroy(gameObject);
            Instantiate(rocket, gameObject.transform.position, Quaternion.identity);
            //rocket.transform.parent.SetParent(rocketContainer.transform);
        }
        else
        {
            transform.Translate(1 * speed, 0, 0);
        }
        
    }
}
