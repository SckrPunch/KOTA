using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject prefab;
    Vector3 colliderPos;
    private void OnMouseDown()
    {
        colliderPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (colliderPos.y >= 3.32 && colliderPos.y <= 4.32)
        {
            Instantiate(prefab, new Vector3(5.42f, 4.11f, 0), Quaternion.identity);
        }
        //colliderPos = this.gameObject.transform.GetChild(0);
        //test = this.gameObject.transform.GetChild(0);

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        //if(Physics.Raycast(ray, out hit))
        //{
        //    colliderPos = hit.collider.transform.position;
        //}

        Debug.Log(colliderPos);
        //Instantiate(prefab, new Vector3(-7.23f, 2.85f, 0), Quaternion.identity);
    }
}
