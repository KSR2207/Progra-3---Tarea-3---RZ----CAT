using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArray : MonoBehaviour
{
    public GameObject[] ballsarray;
    public List<GameObject> ballscatch;
    private bool catchball = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject a = Instantiate(ballsarray[Random.Range(0,ballsarray.Length)], new Vector3(Random.Range(0, 10), 20), Quaternion.identity) as GameObject;
            ballscatch.Add(a);
           
        }

    }


}
