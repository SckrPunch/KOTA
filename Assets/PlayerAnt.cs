using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnt : MonoBehaviour
{
    private Rigidbody2D rb2d;
    /*private Joint2D join;*/
    public Vector2 force = Vector2.up;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        Vector2 startmov = new Vector2(2, 0);
        rb2d.AddForce(startmov * speed);
    }

    // Update is called once per frame
    void Update()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
           float moveVertical = Input.GetAxis("Vertical");
           Vector2 movement = new Vector2(moveHorizontal, moveVertical);
           rb2d.AddForce(movement * speed);*/
        /*if (GetComponent<Collision2D>().otherCollider) ;
        {
            print("cool");
        }
        GetComponent<Joint2D>().attachedRigidbody.AddForce(force);
        //if(GetComponent<Joint2D>().)
        // GetComponent<Joint2D>().attachedRigidbody.AddForce(force);*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
    }
}
