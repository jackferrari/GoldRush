using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObject {

    public Effect right;
    public Effect left;
    public string question;
    public string rightChoice;
    public string leftChoice;

    public QuestionObject(Effect right, Effect left, string question, string rightChoice, string leftChoice)
    {
        this.right = right;
        this.left = left;
        this.question = question;
        this.rightChoice = rightChoice;
        this.leftChoice = leftChoice;
    }
}
