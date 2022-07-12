using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//? Sets game tabs as active/inactive and is accessable by tabbar buttons
public class TabBar : MonoBehaviour
{
    public CanvasGroup game;
    public CanvasGroup character;
    public CanvasGroup abilities;
    public CanvasGroup equipment;

    public List<CanvasGroup> tabWindows = new List<CanvasGroup>();

    // set canvas groups 
    void Awake()
    {
        ChangeCanvasGroup(true, game);
        ChangeCanvasGroup(false, character);
        ChangeCanvasGroup(false, abilities);
        ChangeCanvasGroup(false, equipment);
    }

    // toggle individual canvasgroup as active/inactive with bool b
    void ChangeCanvasGroup(bool b, CanvasGroup g)
    {
        if(b == true)
        {
            g.alpha = 1;
            g.blocksRaycasts = true;
            g.interactable = true;
            return;
        }
        
        g.alpha = 0;
        g.blocksRaycasts = false;
        g.interactable = false;
    }

    // sets active tab from button press & changes all canvasgroups
    public void TabButton(CanvasGroup group)
    {
        // set all groups false
        foreach (var window in tabWindows)
        {
            ChangeCanvasGroup(false, window);
        }

        // set pressed group active
        ChangeCanvasGroup(true, group);
    }
} 