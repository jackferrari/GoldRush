using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrantManager : AManager {

	// Use this for initialization
	void Start () {
        this.BasicSetUp();
        this.level = 2;
        this.questions = new ImmigrantQuestions();
    }
}
