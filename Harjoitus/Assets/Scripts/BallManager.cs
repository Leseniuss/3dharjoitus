using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    [SerializeField]
    GameObject EnemySpawner;
    [SerializeField]
    GameObject BallPreFab;

    GameObject Ball;

    // Start is called before the first frame update
    void Awake()
    {
        Ball = Instantiate(BallPreFab, EnemySpawner.transform.position, EnemySpawner.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball == null)
        {
            Ball = Instantiate(BallPreFab, EnemySpawner.transform.position, EnemySpawner.transform.rotation);
        }
    }
}
