using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public float speed;
    //private GameObject rocket;
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(1 * speed, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Enemy")
        {
            string enemy = collision.gameObject.name;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            FindObjectOfType<EnemyAnt>().speed = 0.05f;
            FoodController.EnemyColliders.Remove(enemy);
        }
    }
}
