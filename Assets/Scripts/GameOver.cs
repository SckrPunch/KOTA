using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Food" && collision.gameObject.transform.position.x > 0)
        {
            Debug.Log("You Lose");
        }
        else if (collision.gameObject.name == "Food" && collision.gameObject.transform.position.x < 0)
        {
            Debug.Log("You Win");
        }
    }
}
