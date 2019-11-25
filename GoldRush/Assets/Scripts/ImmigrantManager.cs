using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrantManager : AManager {

	// Use this for initialization
	void Start () {
        Effect r = new Effect(0, 1, 2);
        Effect l = new Effect(3, 4, 5);

        QuestionObject QO = new QuestionObject(r, l, "You arive in California! Do you try to build your own homestead or move into an existing community?", "Homestead", "Community", "You build a house", "You find a community");
        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        Effect ltEffect = new Effect(50, 30, 10);
        player.SendMessage("ApplyLongTermEffect", ltEffect);
        this.questions = new ImmigrantQuestions();
    }
}
