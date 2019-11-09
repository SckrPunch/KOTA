using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;

    //public string[] colliders = null;
    List<string> PlayerColliders = new List<string>();
    List<string> EnemyColliders = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*int player_count = PlayerColliders.Count;
        int enemy_count = EnemyColliders.Count;
        int total_count = enemy_count - player_count;

        Debug.Log(total_count);
        Debug.Log(speed);
        transform.position = new Vector2(total_count * speed * Time.deltaTime, 0);*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //float initial_velocity = rb2d.velocity.magnitude;
        //Vector2 cancel_velocity = new Vector2(initial_velocity, 0);
        //Debug.Log(cancel_velocity);
        //Debug.Log(cancel_velocity);
        //rb2d.AddForce(cancel_velocity, 0);
        //Debug.Log(rb2d.velocity.magnitude);
        //array implementation
        /*
        int collider_length = colliders.Length;
        //Debug.Log(collider_length);
        colliders[0] = collision.gameObject.name;
        Debug.Log(collider_length);*/

        //list implementation
        if (collision.gameObject.name == "Player")
        {
            PlayerColliders.Add(collision.gameObject.name);
            //Debug.Log("No of players: " + PlayerColliders.Count);
        }
        else
        {
            EnemyColliders.Add(collision.gameObject.name);
            //Debug.Log("No of enemies: "+ EnemyColliders.Count);
        }
        //int players = PlayerColliders.Count;
        //int enemies = EnemyColliders.Count;
        //Vector2 startmov = new Vector2(enemies - players, 0);
        //Debug.Log(startmov);
        //rb2d.AddForce(startmov * speed);

        /*if(collision.gameObject.name == "Player" && collision.gameObject.name == "EnemyAnt")
        {
            Debug.Log("Both hit");
        }
        if (collision.gameObject.name == "Player")
        {
            Vector2 startmov = new Vector2(-2, 0);
            rb2d.AddForce(startmov*speed);
            Debug.Log("Player hit");
        }
       if (collision.gameObject.name == "EnemyAnt")
        {
            Vector2 startmov = new Vector2(2, 0);
            rb2d.AddForce(startmov * speed);
        }*/

    }
}
