using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public void LoadLevel(int i)
    {
        if (i == -1)
        {
            Application.Quit();
        }
        Application.LoadLevel(i);
    }
}
