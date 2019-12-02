using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AllQuestions {

    protected List<QuestionObject> allPossibleQuestions;
    protected QuestionObject lastQuestion;

    public QuestionObject getValidQuestion(int year)
    {
        return this.GetQuestionObject(year);
    }

    protected abstract QuestionObject GetQuestionObject(int year);
}
