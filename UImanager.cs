using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI counter;

    public static UImanager Singleton;
    private void Awake()//ha nem létezik saját magával egyenlõ, akárhol tudunk rá hivatkozni
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
    }

    private int targetsHIT;
    private int targetsSHOT;

    public void incrementTargetsHIT() { targetsHIT++; updateUI(); } 
    public void incrementTargetsSHOT() { targetsSHOT++; updateUI(); }

    private void updateUI()
    {
        counter.text = $"{targetsSHOT}/{targetsHIT}";
    }

}
