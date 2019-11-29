using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AllQuestions {

    protected List<QuestionObject> allPossibleQuestions;

    public List<QuestionObject> getValidQuestions()
    {
        return this.allPossibleQuestions;
    }
}
