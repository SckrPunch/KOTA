using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnt : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Vector2 startmov = new Vector2(-2, 0);
        rb2d.AddForce(startmov * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
    }
}
