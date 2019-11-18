using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{ 

    private Effect rightAnswer;
    private Effect leftAnswer;
    private Effect retEffect;

    public Text question;
    public Text rightText;
    public Text leftText;
    public Text selected;

    private void Start()
    {
        QuestionObject curr = Manager.GetValid();
        this.rightAnswer = curr.right;
        this.leftAnswer = curr.left;
        this.rightText.text = curr.rightChoice;
        this.leftText.text = curr.leftChoice;
        this.question.text = curr.question;
    }

    public void effectClick(string Answer)
    {
        switch (Answer)
        {
            case "Right":
                retEffect = rightAnswer;
                selected.text = rightText.text;
                break;
            case "Left":
                retEffect = leftAnswer;
                selected.text = leftText.text;
                break;
        }
    }

    public Effect getActiveEffect()
    {
        return retEffect;
    }

}
