using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer {

    public Effect applyEffect;
    public string outcome;

    public Answer(Effect e, string outcome)
    {
        this.applyEffect = e;
        this.outcome = outcome;
    }
}
