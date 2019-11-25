using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNugget : MonoBehaviour
{

    public GameObject nugget;
    public int wait;

    private void Start()
    {
        wait = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (wait > 0)
        {
            wait--;
        }
        else
        {
            int spawnNumber = Random.Range(0, 200);
            if (spawnNumber > 10)
            {
                Instantiate(nugget, transform.position, transform.rotation);
            }
            wait = Random.Range(50, 200);
        }

    }
}
