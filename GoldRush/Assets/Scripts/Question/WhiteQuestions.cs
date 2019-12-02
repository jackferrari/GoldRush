using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteQuestions : AllQuestions {

	public WhiteQuestions()
    {
        this.allPossibleQuestions = new List<QuestionObject>();
        Effect decreaseGold = new Effect(0, -10, 0);
        Effect hiredFriend = new Effect(0, 20, 15);
        Effect startedPayingMore = new Effect(0, 0, 10);
        Effect nothingNew = new Effect(0, 0, 0);
        Effect kickedOutNatives = new Effect(10, 20, 0);
        Effect joinedSmallCompany = new Effect(10, -5, -3);
        Effect gotSickForAWhile = new Effect(0, -20, 5);
        Effect claimBoughtOut = new Effect(30, -30, 5);
        Effect failedCompany = new Effect(0, -5, 50);
        Effect gotMoreGold = new Effect(0, 5, 0);
        Effect builtHouseWing = new Effect(0, 0, 50);
        Effect smallGoldDecrease = new Effect(0, -5, 0);
        Effect quickFailedCompany = new Effect(0, 5, 30);
        Effect cheapSupplies = new Effect(0, 0, -10);
        Effect backedSmallBusiness = new Effect(50, 0, 20);
        Effect wifeIsDisgusted = new Effect(0, 0, 30);
        Effect wifeSupported = new Effect(0, 0, 15);
        Effect nativeSudoSlave = new Effect(0, 20, 5);

        QuestionObject q1 = new QuestionObject(failedCompany, gotMoreGold,
            "One of your friends offers to let you buy into his company and work there for the next couple of months. Alternatively you could continue to work at prospecting.",
            "Sign on to your Friend's company",
            "Prospect in the nearby river",
            "Your group's attempts to divert water and mine a riverbed failed due to the heavy riverbed rocks and you make no money.",
            "The River had too much water and you have difficulty finding gold.");

        QuestionObject q2 = new QuestionObject(startedPayingMore, decreaseGold,
            "Your cradle breaks. You need a cradle to seperate dirt and gold, so you decide to replace it.",
            "You buy a new one",
            "You attempt to fixes yourself",
            "It costs you some money but you get back to work",
            "It doesn't work very well for some time and eventually you get one from someone going back east");

        QuestionObject q3 = new QuestionObject(nothingNew, builtHouseWing,
            "You are forced to pay for an expensive fix to your house.",
            "Write home to try to try to get money",
            "Pay with your money in the West",
            "Your wife is able to call in debts and get you the money",
            "It really costs you, but your family at least was not put through financial hardship");

        QuestionObject q4 = new QuestionObject(smallGoldDecrease, decreaseGold,
            "You are not eating right and feel your teeth loosening from scurvy",
            "Eat grass, it might help",
            "Try to find better food",
            "It does help...",
            "You are unable to find a fruit vendor and you loose some teeth.");

        QuestionObject q5 = new QuestionObject(gotSickForAWhile, decreaseGold,
            "The wet season creates sickness throughout the camp and you become very sick.",
            "Rest to try to recover",
            "Keep working",
            "You recover, but find little gold",
            "You don't recover soon. You collect little and end up never fully recovering");

        QuestionObject q6 = new QuestionObject(quickFailedCompany, nothingNew,
            "A few people you know offer you a chance to block up a river to mine out the gold.",
            "Pay in to the company",
            "move on to find another opportunity",
            "Your group tries to dam the river but more rain than usual slows and eventually stops you",
            "You end up just panning for gold in the river");

        QuestionObject q7 = new QuestionObject(cheapSupplies, nothingNew,
            "A steam boat comes down the river",
            "Try to trade with it",
            "ignore it and stick with your current supplies",
            "The boat has cheap supplies that it is selling!",
            "Life goes on unchanged");

        QuestionObject q8 = new QuestionObject(smallGoldDecrease, smallGoldDecrease,
            "A friend from home writes you to ask if he should come out to mine in the west",
            "Discourage him",
            "Tell stories about the gold",
            "While your friend does not come, your warnings are drowned out by stories of gold and many more people come west",
            "Your friend along with thousands more people come out west to try to get a gold claim");

        QuestionObject q9 = new QuestionObject(nothingNew, decreaseGold,
            "Your claim seems like it has no gold",
            "Stick with it and hope you eventually find gold",
            "try a new claim",
            "Your claim stays about the same",
            "Your new claim is worse than your original");

        QuestionObject q10 = new QuestionObject(nothingNew, gotMoreGold,
            "Your claim seems like it has no gold",
            "Stick with it and hope you eventually find gold",
            "try a new claim",
            "Your claim stays about the same",
            "Your new claim is better than the last");

        QuestionObject q11 = new QuestionObject(backedSmallBusiness, nothingNew,
            "Your friend asks for some money to start a mining equipment shop",
            "Give him the money",
            "Don't give him the money",
            "He strikes it rich selling supplies to new miners and rewards you for your investment",
            "Nothing really happens");

        QuestionObject q12 = new QuestionObject(wifeIsDisgusted, wifeSupported,
            "Your wife writes to say that she is having troubles back home",
            "Tell her to come out west with you",
            "Send her home some money",
            "Upon arriving your wife realizes the kind of behavior that you engage in at the camps and leaves disgusted with you and with a lot of money",
            "The money you send her is put to good use");

        QuestionObject q13 = new QuestionObject(nothingNew, nothingNew,
            "You are called to a camp trial over a supposed crime by a Mexican citizen",
            "Vote guilty",
            "Vote not guilty",
            "The Mexican is found guilty",
            "The Mexican is still found guilty");

        QuestionObject q14 = new QuestionObject(kickedOutNatives, nothingNew,
            "You hear rumours of gold on native lands",
            "Join a vigilanty group",
            "stay with your current claim",
            "The state government does nothing to punish you and eventually the army comes in to deal with the natives you fought. You get the valuable land",
            "You hear that the others made a lot of money from the land they were able to take, but your decendents get to say that you didn't participate in that genocide");

        QuestionObject q15 = new QuestionObject(nativeSudoSlave, hiredFriend,
            "You find that you want some help around your land",
            "Lease a native prisoner",
            "Offer someone full pay to work for you",
            "You are able to boost your productivity while also paying very little income",
            "You end up paying a lot");

        this.allPossibleQuestions.Add(q1);
        this.allPossibleQuestions.Add(q2);
        this.allPossibleQuestions.Add(q3);
        this.allPossibleQuestions.Add(q4);
        this.allPossibleQuestions.Add(q5);
        this.allPossibleQuestions.Add(q6);
        this.allPossibleQuestions.Add(q7);
        this.allPossibleQuestions.Add(q8);
        this.allPossibleQuestions.Add(q9);
        this.allPossibleQuestions.Add(q10);
        this.allPossibleQuestions.Add(q11);
        this.allPossibleQuestions.Add(q12);
        this.allPossibleQuestions.Add(q13);
        this.allPossibleQuestions.Add(q14);
        this.allPossibleQuestions.Add(q15);
        this.lastQuestion = new QuestionObject(null, null, "", "", "", "", "");
    }

    protected override QuestionObject GetQuestionObject(int year)
    {
        QuestionObject potential = this.allPossibleQuestions[Random.Range(0, allPossibleQuestions.Count)];
        while (potential.question == this.lastQuestion.question)
        {
            potential = this.allPossibleQuestions[Random.Range(0, this.allPossibleQuestions.Count)];
        }
        this.lastQuestion = potential;
        return potential;
    }
}
