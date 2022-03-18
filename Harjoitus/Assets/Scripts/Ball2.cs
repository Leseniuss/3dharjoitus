using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2 : MonoBehaviour
{

    GameManager gm;


    void Start()
    {
        gm = GameObject.Find("environment").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Destroy(gameObject);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {


            gm.Finish2();


        }
    }



}
