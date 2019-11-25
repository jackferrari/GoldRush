using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nugget : MonoBehaviour {

    public float x;
    public float y;

    public float rotZ;

	// Update is called once per frame
	void Update () { 
        transform.Translate(new Vector2(x, y), Space.World);
        transform.Rotate(0, 0, rotZ, Space.Self);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("edge"))
        {
            Destroy(this.gameObject);
        }
    }
}
