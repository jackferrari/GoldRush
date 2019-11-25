using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AManager: MonoBehaviour {

    public GameObject player;
    public GameObject questionObject;
    protected AllQuestions questions;
    protected QuestionObject lastQuestion;

    protected void UpdateQuestion()
    {
        QuestionObject QO = this.GetGoodQuestion();
        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        List<QuestionObject> questionObjects = new List<QuestionObject>();

    }

    protected QuestionObject GetGoodQuestion()
    {
        List<QuestionObject> options = this.questions.getValidQuestions();
        QuestionObject potential = options[Random.Range(0, options.Count - 1)];
        while (potential.question == this.lastQuestion.question)
        {
            potential = options[Random.Range(0, options.Count - 1)];
        }
        return potential;
    }

    protected void UpdatePlayer(Effect e)
    {
        player.SendMessage("NextTurn", e);
        UpdateQuestion();
    }

}
