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

    public bool immigrant;

    public int cash;
    public int maxChange;
    public int livingCost;

    private int lastGold;
    private int lastOther;
    private int lastCost;

    public void Start()
    {
        this.lastGold = 0;
        this.lastOther = 0;
        this.lastCost = 0;
    }

    public void Update()
    {
        this.money.text = "$" + this.cash;
        this.cost.text = "$" + this.lastCost;
        this.otherIncome.text = "$" + this.lastOther;
        this.gold.text = "$" + this.lastGold;
    }

    public void ApplyLongTermEffect(Effect app)
    {
        this.cash += app.diffMoney;
        this.maxChange = GetMaxGet(app.diffGet);
        this.livingCost += app.diffCost;
    }

    public void NextTurn(Effect effect)
    {
        this.lastGold = Random.Range(0, GetMaxGet(effect.diffGet));
        this.lastCost = (this.livingCost + effect.diffCost);
        this.lastOther = effect.diffMoney;
        this.cash = (this.cash + this.lastOther) + this.lastGold - this.lastCost;
    }

    private int GetMaxGet(int diff)
    {
        if (this.maxChange + diff < 0)
        {
            return 0;
        }
        else
        {
            return this.maxChange + diff;
        }
    }

    public void SetEndStory(int year)
    {
        switch(year)
        {
            case 1849:
                PlayerPrefs.SetString("EndStory", "This whole gold rush thing really just wasn't for you. Probably for the best you make your way home.");
                break;
            case 1850:
            case 1851:
            case 1852:
            case 1853:
            case 1854:
                PlayerPrefs.SetString("EndStory", "You walk off into the sunset, leaving the gold rush behind with $" + this.cash + " in your pocket. You return east with your profit and end up working in a factory. Thanks for playing");
                break;
            case 1855:
                PlayerPrefs.SetString("EndStory", "You never leave the gold rush days, but find that gold is too scarse for you alone. You become a wage miner");
                break;
            default:
                PlayerPrefs.SetString("EndStory", "There was a problem with your rushing gold");
                break;
        }
        Application.LoadLevel(3);

    }

}
