using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNugget : MonoBehaviour {

    public GameObject nugget;
	
	// Update is called once per frame
	void Update () {
        int spawnNumber = Random.Range(0, 20);
        if (spawnNumber > 12)
        {
            Instantiate(nugget, transform.position, transform.rotation);
        }
	}
}
