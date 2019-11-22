using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObject {

    public Effect right;
    public Effect left;
    public string question;
    public string rightChoice;
    public string leftChoice;
    public string rightResult;
    public string leftResult;

    public QuestionObject(Effect right, Effect left, string question,
        string rightChoice, string leftChoice, string rightResult, string leftResult)
    {
        this.right = right;
        this.left = left;
        this.question = question;
        this.rightChoice = rightChoice;
        this.leftChoice = leftChoice;
        this.rightResult = rightResult;
        this.leftResult = leftResult;
    }
}
