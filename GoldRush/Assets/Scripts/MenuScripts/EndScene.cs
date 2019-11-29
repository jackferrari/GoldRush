using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScene : MonoBehaviour {

    public Text endDialogue;

    private void Start()
    {
        int year = PlayerPrefs.GetInt("Year");
        string story = PlayerPrefs.GetString("EndStory");

        string dialogue = "You left in " + year + ". " + story;

        this.endDialogue.text = dialogue;
    }

    public void Menu()
    {
        Application.LoadLevel(0);
    }

    public void PreviousLevel()
    {
        Application.LoadLevel(PlayerPrefs.GetInt("PrevLevel"));
    }
}
