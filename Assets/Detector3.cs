using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector3 : MonoBehaviour
{
    private bool status;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            status = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            status = false;
        }
    }
    public bool CheckLane()
    {
        return status;
    }
}
