using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static QuestionObject GetValid()
    {
        Effect r = new Effect(0, 1, 2);
        Effect l = new Effect(3, 4, 5);

        return new QuestionObject(r, l, "What is that", "nothing", "something");
    }
}
