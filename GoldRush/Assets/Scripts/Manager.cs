using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject player;
    public GameObject questionObject;
    private int i;

    public void Start()
    {
        i = 0;
        Effect r = new Effect(0, 1, 2);
        Effect l = new Effect(3, 4, 5);

        QuestionObject QO = new QuestionObject(r, l, "You arive in California! Do you try to build your own homestead or move into an existing community?", "Homestead", "Community");
        questionObject.SendMessage("SetUp", QO);
    }

    private void UpdateQuestion()
    {
        Effect r = new Effect(0, 1, 2);
        Effect l = new Effect(3, 4, 5);
        i++;
        QuestionObject QO = new QuestionObject(r, l, "Question " + i, "yes", "no");
        questionObject.SendMessage("SetUp", QO);
    }

    private void UpdatePlayer(Effect e)
    {
        player.SendMessage("NextTurn", e);
        UpdateQuestion();
    }
}
