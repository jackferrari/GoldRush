using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrantQuestions : AllQuestions {


    public ImmigrantQuestions()
    {
        this.allPossibleQuestions = new List<QuestionObject>();
        Effect decreaseGold = new Effect(0, -10, 0);
        Effect hiredFriend = new Effect(0, 20, 30);
        Effect getFreeMoney = new Effect(15, 0, 0);
        Effect startedPayingMore = new Effect(0, 0, 10);
        Effect nothingNew = new Effect(0, 0, 0);
        Effect kickedOutNatives = new Effect(0, 20, 0);
        Effect joinedSmallCompany = new Effect(10, -5, -3);
        Effect gotSickForAWhile = new Effect(0, -20, 5);
        Effect claimBoughtOut = new Effect(30, -30, 5);
        Effect payTheMob = new Effect(0, 0, 30);
        Effect resistTheMob = new Effect(0, -5, 45);
        Effect payOffCredit = new Effect(0, 0, 5);
        Effect smallGoldDecrease = new Effect(0, -5, 0);
        Effect cheapSupplies = new Effect(0, 0, -10);
        Effect gotMoreGold = new Effect(0, 5, 0);
        Effect failedCompany = new Effect(0, -5, 50);
        Effect leftWhileYouHadTheChance = new Effect(5, -5, 10);

        QuestionObject q1 = new QuestionObject(getFreeMoney, nothingNew,
            "You are offered a job as a laundry worker for your camp.",
            "Accept",
            "Decline",
            "You manage to have steady work for a little while",
            "you continue to try to get gold");

        QuestionObject q2 = new QuestionObject(payTheMob, resistTheMob,
            "An angry mob approaches your camp demanding you stop stealing the gold from California",
            "Try to pay them off",
            "Assert your right to mine here too",
            "They leave at great expence",
            "They take a lot of money's worth of supplies and equipment and force you to a different plot");

        QuestionObject q3 = new QuestionObject(startedPayingMore, startedPayingMore,
            "Part of the debt from your crossing has come due",
            "Pay",
            "Try to dodge it",
            "You pay the ammount in full.",
            "Your attempts fail and you pay the ammount in full");

        QuestionObject q6 = new QuestionObject(startedPayingMore, decreaseGold,
            "Your cradle breaks. You need a cradle to seperate dirt and gold, so you decide to replace it.",
            "You buy a new one",
            "You attempt to fixes yourself",
            "It costs you some money but you get back to work",
            "It doesn't work very well for some time and eventually you get one from someone going back east");

        QuestionObject q7 = new QuestionObject(smallGoldDecrease, decreaseGold,
            "You are not eating right and feel your teeth loosening from scurvy.",
            "Eat grass, it might help",
            "Try to find better food",
            "It does help...",
            "You are unable to find a fruit vendor and you loose some teeth.");

        QuestionObject q8 = new QuestionObject(gotSickForAWhile, decreaseGold,
            "The wet season creates sickness throughout the camp and you become very sick.",
            "Rest to try to recover",
            "Keep working",
            "You recover, but find little gold",
            "You don't recover soon. You collect little and end up never fully recovering");

        QuestionObject q9 = new QuestionObject(cheapSupplies, nothingNew,
            "A steam boat comes down the river",
            "Try to trade with it",
            "ignore it and stick with your current supplies",
            "The boat has cheap supplies that it is selling!",
            "Life goes on unchanged");

        QuestionObject q10 = new QuestionObject(nothingNew, decreaseGold,
            "Your claim seems like it has no gold",
            "Stick with it and hope you eventually find gold",
            "try a new claim",
            "Your claim stays about the same",
            "Your new claim is worse than your original");

        QuestionObject q11 = new QuestionObject(nothingNew, gotMoreGold,
            "Your claim seems like it has no gold",
            "Stick with it and hope you eventually find gold",
            "try a new claim",
            "Your claim stays about the same",
            "Your new claim is better than the last");

        QuestionObject q12 = new QuestionObject(failedCompany, gotMoreGold,
            "One of your friends offers to let you buy into his company and work there for the next couple of months. Alternatively you could continue to work at prospecting.",
            "Sign on to your Friend's company",
            "Prospect in the nearby river",
            "Your group's attempts to divert water and mine a riverbed failed due to the heavy riverbed rocks and you make no money.",
            "The River had too much water and you have difficulty finding gold.");

        QuestionObject q13 = new QuestionObject(leftWhileYouHadTheChance, payTheMob,
            "You are informed the local government has banned Chinese miners from the county.",
            "Leave",
            "Try to stay",
            "You grab as much money as possible and move to another county",
            "You are are driven from the town by a mob. You left a lot behind");

        QuestionObject q14 = new QuestionObject(startedPayingMore, payTheMob,
            "You decide to send some gold back home.",
            "Send a few small nuggets",
            "Send much of what you have",
            "Your family's status back in China slightly improves",
            "Your family's status back in China greatly improves and you recieve a letter informing you that you have a marriage planned if you return");

        this.allPossibleQuestions.Add(q3);
        this.allPossibleQuestions.Add(q1);
        this.allPossibleQuestions.Add(q2);
        this.allPossibleQuestions.Add(q6);
        this.allPossibleQuestions.Add(q7);
        this.allPossibleQuestions.Add(q8);
        this.allPossibleQuestions.Add(q9);
        this.allPossibleQuestions.Add(q10);
        this.allPossibleQuestions.Add(q11);
        this.allPossibleQuestions.Add(q12);
        this.allPossibleQuestions.Add(q13);
        this.allPossibleQuestions.Add(q14);
        this.lastQuestion = new QuestionObject(null, null, "", "", "", "", "");
    }

    protected override QuestionObject GetQuestionObject(int year)
    {
        QuestionObject q4 = new QuestionObject(new Effect(0, 0, 20), new Effect(-1000, -1000, -1000),
            "California passes the Foreign Miners Tax of 1850. You are forced to pay a large fee on your claims. It is $20.",
            "Pay",
            "Don't pay",
            "You pay the tax",
            "you are deported");

        QuestionObject q5 = new QuestionObject(new Effect(0, 0, 10), new Effect(-1000, -1000, -1000),
            "The original Foreign Miners Tax has been was repealed, but has now been replaced with a new Foreign Miners Tax.",
            "Pay now and live on less supplies in the future",
            "Don't pay",
            "You pay the new monthly fee",
            "you are deported");

        QuestionObject potential;
        if (year == 1850)
        {
            potential = q4;
        }
        else if (year == 1852)
        {
            potential = q5;
        }
        else
        {
            potential = this.allPossibleQuestions[Random.Range(0, allPossibleQuestions.Count)];
        }
        while (potential.question == this.lastQuestion.question)
        {
            potential = this.allPossibleQuestions[Random.Range(0, this.allPossibleQuestions.Count)];
        }
        this.lastQuestion = potential;
        return potential;
    }
}
