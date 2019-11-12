using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;

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
        
        if (collision.gameObject.name == "Player")
        {
            PlayerColliders.Add(collision.gameObject.name);
            Debug.Log("No of players: " + PlayerColliders.Count);
        }
        else
        {
            EnemyColliders.Add(collision.gameObject.name);
            Debug.Log("No of enemies: "+ EnemyColliders.Count);
        }
        

    }

}
