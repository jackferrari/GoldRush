using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect {
    public int diffMoney;
    public int diffGet;
    public int diffCost;

    public Effect(int diffMoney, int diffGet, int diffCost)
    {
        this.diffMoney = diffMoney;
        this.diffGet = diffGet;
        this.diffCost = diffCost;
    }
}
