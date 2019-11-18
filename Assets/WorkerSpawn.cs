using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerSpawn : MonoBehaviour
{
    public GameObject PlayerWorker;
    //private GameObject PlayerWorker_Container;
    //public GameObject Parent;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(PlayerWorker, new Vector3(-2, 3.9f, 0), Quaternion.identity);
        Instantiate(PlayerWorker, new Vector3(-5, 2.85f, 0), Quaternion.identity);
        //PlayerWorker.transform.SetParent(Parent.transform);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
