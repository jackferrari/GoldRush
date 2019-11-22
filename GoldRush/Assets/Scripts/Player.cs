using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text money;
    public Text otherIncome;
    public Text cost;
    public Text gold;

    public int cash;
    public int maxChange;
    public int livingCost;

    public void Start()
    {
        this.money.text = "$" + this.cash;
        this.cost.text = "$" + this.livingCost;
        this.gold.text = "$" + 0;
        this.otherIncome.text = "$" + 0;
    }

    public void ApplyLongTermEffect(Effect app)
    {
        this.cash += app.diffMoney;
        this.maxChange += app.diffGet;
        this.livingCost += app.diffCost;
    }

    public void NextTurn(Effect effect)
    {
        int gottenGold = Random.Range(0, (this.maxChange + effect.diffGet));
        int gottenCost = (this.livingCost + effect.diffCost);
        this.cash = (this.cash + effect.diffMoney) + gottenGold - gottenCost;
        this.money.text = "$" + this.cash;
        this.cost.text = "$" + gottenCost;
        this.gold.text = "$" + gottenGold;
        this.gold.text = "$" + effect.diffMoney;
    }
	
}
