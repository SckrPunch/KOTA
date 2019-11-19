using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool move_flag;

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
        int player_count = PlayerColliders.Count;
        int enemy_count = EnemyColliders.Count;
        int total_count = enemy_count - player_count;
        //Debug.Log("Player count:" + player_count);
        //Debug.Log("Enemy count:" + enemy_count);
        //Debug.Log("Total count:" + total_count);
        //Debug.Log(rb2d.position.y);
        //rb2d.transform.parent.position = new Vector2(total_count * speed * Time.deltaTime, rb2d.transform.position.y);
        //transform.position = new Vector2(total_count * speed * Time.deltaTime, transform.position.y);
        //Debug.Log(total_count * speed);
        if(move_flag == true)
        {
            //Debug.Log(total_count);
            rb2d.transform.parent.Translate(total_count * speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "Player")
        {
            PlayerColliders.Add(collision.gameObject.name);
            //Debug.Log("No of players: " + PlayerColliders.Count);
            collision.transform.parent = rb2d.transform.parent;
            //Debug.Log(collision.transform.parent);
            move_flag = true;
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            EnemyColliders.Add(collision.gameObject.name);
            //Debug.Log("No of enemies: "+ EnemyColliders.Count);
            collision.transform.parent = rb2d.transform.parent;
            move_flag = true;
        }
        else if (collision.gameObject.tag == "Default")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), rb2d.GetComponent<Collider2D>());
        }

        //Debug.Log(collision.transform.parent.gameObject.name);
    }

}
