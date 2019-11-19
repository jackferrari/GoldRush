using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int money;
    public int maxChange;
    public int livingCost;

    public void applyEffect(Effect app)
    {
        this.money = this.money + app.diffMoney;
        this.maxChange = this.maxChange + app.diffGet;
        this.livingCost = this.livingCost + app.diffCost;
    }

    public void nextTurn()
    {
        Random random = new Random();
        this.money = this.money + Random.Range(0, this.maxChange) - this.livingCost;
    }
	
}
