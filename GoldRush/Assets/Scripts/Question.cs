using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public GameObject manager;

    private Effect rightAnswer;
    private Effect leftAnswer;

    public Text question;
    public Text rightText;
    public Text leftText;

    void SetUp(QuestionObject curr)
    {
        this.rightAnswer = curr.right;
        this.leftAnswer = curr.left;
        this.rightText.text = curr.rightChoice;
        this.leftText.text = curr.leftChoice;
        this.question.text = curr.question;
    }

    public void EffectClick(string Answer)
    {
        switch (Answer)
        {
            case "Right":
                manager.SendMessage("UpdatePlayer", rightAnswer);
                break;
            case "Left":
                manager.SendMessage("UpdatePlayer", leftAnswer);
                break;
        }
    }
}
