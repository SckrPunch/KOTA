﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnt : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * speed, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
    }
}
