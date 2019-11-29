using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteManager : AManager {

    public void Start()
    {
        this.BasicSetUp();
        this.level = 1;
        questions = new WhiteQuestions();
    }
}
