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

    public GameObject retire;

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

        if (this.cash < 0)
        {
            retire.SetActive(false);
        }
        else
        {
            retire.SetActive(true);
        }
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
        if (PlayerPrefs.HasKey("Deported") && PlayerPrefs.GetString("Deported").Equals("was"))
        {
            PlayerPrefs.SetString("EndStory", "Your refusal to pay the Foreign Miners Tax ended your mining career. The government seizes your land and locks you up. You end up being put on a boat back to China, deported.");
        }
        else
        {
            switch (year)
            {
                case 1849:
                    PlayerPrefs.SetString("EndStory", Outcome(year));
                    break;
                case 1850:
                case 1851:
                case 1852:
                case 1853:
                case 1854:
                    PlayerPrefs.SetString("EndStory", Outcome(year) + " You leave with $" + this.cash + ".");
                    break;
                case 1855:
                    PlayerPrefs.SetString("EndStory", Outcome(year));
                    break;
                default:
                    PlayerPrefs.SetString("EndStory", "There was a problem with your rushing gold.");
                    break;
            }
        }
        Application.LoadLevel(3);
    }


    private string Outcome(int year)
    {
        if (year == 1855 && this.cash <= 0)
        {
            return "Broke and falling deeper into debt, your dreams of making it on your own are over. You end up signing on to an industrial gold mining endevor and work as a wage miner for the rest of your life.";
        }
        else if (year < 1851 && this.cash > 60 && !this.immigrant)
        {
            return "You stay for a short time and leave with a decent profit. You head back east to your family, having made a decent profit and are able to expand your farm.";
        }
        else if (year < 1851 && this.cash > 60 && this.immigrant)
        {
            return "You stay for a short time and leave with a decent profit. You move to a small town and set up a small business and live the rest of your days mostly peacefully.";
        }
        else if (year == 1849 && this.cash == 30)
        {
            return "This whole gold rush thing really just wasn't for you. Probably for the best you make your way home. Hope you enjoyed the trip to California.";
        }
        else if (year == 1855 && this.cash > 0)
        {
            return "You were able to successfully balance your finances for a long time, but now you realize that the surface gold has run out. You retire, but the years of gold mining take their toll and you are never truly healthy again.";
        }
        else if (this.cash > 50)
        {
            return "You remain weak from living in the wilderness so long, but the wealth you bring home more than compensates for this. "
        }
        else
        {
            return "You are able to leave the West with a little money. However you remain weak the rest of your life from the hard living you faced in your years of gold mining.";
        }
    }
}
