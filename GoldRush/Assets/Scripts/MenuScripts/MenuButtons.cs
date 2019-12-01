using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public GameObject warning;
    private int load = 0;
    private bool canLoad = false;
    private int wait = 0;

    public void LoadLevel(int i)
    {
        warning.SetActive(true);
        this.load = i;
        this.canLoad = true;
        if (i == -1)
        {
            Application.Quit();
        }
    }

    private void Update()
    {
        if (canLoad)
        {
            if (wait > 100)
            {
                Application.LoadLevel(load);
            }
            else
            {
                wait++;
            }
        }
    }
}
