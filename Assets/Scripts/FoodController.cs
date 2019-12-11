using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool move_flag;

    public float speed;

    public static List<string> PlayerColliders = new List<string>();
    public static List<string> EnemyColliders = new List<string>();
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

        if(move_flag == true)
        {
            rb2d.transform.parent.Translate(total_count * speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool Player_exist = PlayerColliders.Contains(collision.gameObject.name);
        bool enemy_exist = EnemyColliders.Contains(collision.gameObject.name);

        if (collision.gameObject.tag == "Player" && !Player_exist)
        {
            PlayerColliders.Add(collision.gameObject.name);
            collision.transform.parent = rb2d.transform.parent;
            move_flag = true;
        }
        else if(collision.gameObject.tag == "Enemy" && !enemy_exist)
        {
            EnemyColliders.Add(collision.gameObject.name);
            collision.transform.parent = rb2d.transform.parent;
            move_flag = true;
        }
        else if (collision.gameObject.tag == "Default")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), rb2d.GetComponent<Collider2D>());
        }

    }

}
