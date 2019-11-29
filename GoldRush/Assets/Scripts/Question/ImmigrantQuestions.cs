using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrantQuestions : AllQuestions {


    public ImmigrantQuestions()
    {
        this.allPossibleQuestions = new List<QuestionObject>();
        Effect decreaseGold = new Effect(0, -10, 0);
        Effect hiredFriend = new Effect(0, 20, 30);
        Effect getFreeMoney = new Effect(10, 0, 0);
        Effect startedPayingMore = new Effect(0, 0, 10);
        Effect nothingNew = new Effect(0, 0, 0);
        Effect kickedOutNatives = new Effect(0, 20, 0);
        Effect joinedSmallCompany = new Effect(10, -5, -3);
        Effect gotSickForAWhile = new Effect(0, -20, 5);
        Effect claimBoughtOut = new Effect(30, -30, 5);

        QuestionObject q1 = new QuestionObject(decreaseGold, nothingNew, "You are shunned by the community at large.", "Stay put", "Try a new area", "You decide to stay", "You find a new area that feels more promising");
        QuestionObject q2 = new QuestionObject(hiredFriend, joinedSmallCompany, "This year you decide to try to get some help.", "Hire Help", "Join Company", "You hire a friend who can help you", "You sign up with a company for a year");
        QuestionObject q3 = new QuestionObject(kickedOutNatives, nothingNew, "You are informed that the army has just kicked the Natives off some land", "Move to that land", "Don't move", "The native lands had gold!", "You are more respected by your far descendants, but no richer");
        QuestionObject q4 = new QuestionObject(gotSickForAWhile, startedPayingMore, "You need to reinforce the roof of your house and or the rains will soak you", "Ignore the problem", "pay for a better roof", "You get sick from the dampness and poor conditions", "You fix up your house");
        QuestionObject q5 = new QuestionObject(claimBoughtOut, nothingNew, "You are approached by a man who offers to buy your claim", "Sell", "Don't Sell", "You give that sucker your worthless land", "You hold on to the most valuable land");
        QuestionObject q6 = new QuestionObject(getFreeMoney, nothingNew, "You think about writing home", "Write home", "Nothing has happened, don't write", "Your grandpa died and left you some money", "No need to bother the folks back home");

        this.allPossibleQuestions.Add(q1);
        this.allPossibleQuestions.Add(q2);
        this.allPossibleQuestions.Add(q3);
        this.allPossibleQuestions.Add(q4);
        this.allPossibleQuestions.Add(q5);
        this.allPossibleQuestions.Add(q6);
    }
}
