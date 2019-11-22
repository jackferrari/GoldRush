using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject player;
    public GameObject questionObject;
    private int i;
    private AllQuestions questions;
    private QuestionObject lastQuestion;

    public void Start()
    {
        i = 0;
        Effect r = new Effect(0, 1, 2);
        Effect l = new Effect(3, 4, 5);

        QuestionObject QO = new QuestionObject(r, l, "You arive in California! Do you try to build your own homestead or move into an existing community?", "Homestead", "Community");
        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        Effect ltEffect = new Effect(50, 30, 10);
        player.SendMessage("ApplyLongTermEffect", ltEffect);
        questions = new WhiteQuestions();
    }

    private void UpdateQuestion()
    {
        QuestionObject QO = this.GetGoodQuestion();
        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        List<QuestionObject> questionObjects = new List<QuestionObject>();
        
    }

    private QuestionObject GetGoodQuestion()
    {
        List<QuestionObject> options = this.questions.getValidQuestions();
        QuestionObject potential = options[Random.Range(0, options.Count - 1)];
        while (potential.question == this.lastQuestion.question)
        {
            potential = options[Random.Range(0, options.Count - 1)];
        }
        return potential;
    }

    private void UpdatePlayer(Effect e)
    {
        player.SendMessage("NextTurn", e);
        UpdateQuestion();
    }
}
