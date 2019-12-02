using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteManager : AManager {

    public void Start()
    {
        Effect nothing = new Effect(0, 0, 0);

        QuestionObject QO = new QuestionObject(nothing, nothing,
            "You arive in California! When you heard about the gold out west you knew it was your ticket to improve your family's life. You left your wife behind and made the grueling trip west. Now you are here and have your claim and equipment layed out.",
            "Welcome", "Welcome",
            "You have arrived. Time to find your fortune!",
            "You have arrived. Time to find your fortune!");

        this.BasicSetUp(QO);
        this.level = 1;
        questions = new WhiteQuestions();
    }
}
