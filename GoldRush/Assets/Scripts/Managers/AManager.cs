using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AManager: MonoBehaviour {

    public GameObject player;
    public GameObject questionObject;

    public GameObject hider;
    public Text info;
    public Text contButton;

    public Text year;
    protected int yearVal;
    private int turn;

    protected int level;

    protected AllQuestions questions;
    protected QuestionObject lastQuestion;

    protected void BasicSetUp(QuestionObject QO)
    {
        this.yearVal = 1849;
        this.year.text = "" + this.yearVal;
        this.hider.SetActive(false);

        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        Effect ltEffect = new Effect(50, 30, 10);
        player.SendMessage("ApplyLongTermEffect", ltEffect);
    }

    protected void UpdateQuestion()
    {
        QuestionObject QO = this.GetGoodQuestion();
        this.lastQuestion = QO;
        questionObject.SendMessage("SetUp", QO);
        List<QuestionObject> questionObjects = new List<QuestionObject>();
    }

    private void Update()
    {
        this.year.text = "" + yearVal;
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

    protected void UpdatePlayer(Answer a)
    {
        turn++;
        player.SendMessage("NextTurn", a.applyEffect);
        UpdateQuestion();
        if (this.turn % 2 == 0)
        {
            this.yearVal++;
            Effect reduce = new Effect(0, -5, 0);
            player.SendMessage("ApplyLongTermEffect", reduce);
        }
        if (this.yearVal == 1855)
        {
            this.contButton.text = "End Game";
        }
        this.hider.SetActive(true);
        this.info.text = a.outcome;
    }

    public void EndSequence()
    {
        PlayerPrefs.SetInt("Year", this.yearVal);
        PlayerPrefs.SetInt("PrevLevel", this.level);
        player.SendMessage("SetEndStory", this.yearVal);
    }

    public void ContinueGame()
    {
        if (this.yearVal != 1855)
        {
            this.hider.SetActive(false);
        }
        else
        {
            this.EndSequence();
        }
    }

}
