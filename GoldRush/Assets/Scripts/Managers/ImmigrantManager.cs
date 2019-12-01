using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrantManager : AManager {

	// Use this for initialization
	void Start ()
    {
        Effect nothing = new Effect(0, 0, 0);

        QuestionObject QO = new QuestionObject(nothing, nothing, "You arive in California! When you heard about the gold and decided to travel to America to try to strike it rich. You took out a credit agreement to pay for your passage and managed to buy a claim and hope to find opportunity in this new land", "Welcome", "Welcome", "You have arrived. Time to find wealth", "You have arrived. Time to find your wealth.");

        this.BasicSetUp(QO);
        this.level = 2;
        this.questions = new ImmigrantQuestions();
    }
}
