using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnt : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * speed, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
        if (SpawnIndicatorClick.count == 1)
        {
            FoodController.PlayerColliders.Add("PlayerAnt(Clone)");
            gameObject.transform.parent = FindObjectOfType<FoodController>().transform.parent;
            SpawnIndicatorClick.count = 0;
        }
    }
}
