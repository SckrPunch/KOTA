using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRocketScript : MonoBehaviour
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

        if (collision.gameObject.tag == "Player")
        {
            string Player = collision.gameObject.name;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            FoodController.PlayerColliders.Remove(Player);
        }
    }
}
