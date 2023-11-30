using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenTest : MonoBehaviour, Iscreen
{
    public ScreenTest newWindow;
    public void BTN_Active()
    {
        ScreenManager.instance.ActiveScreen(newWindow);
    }   
    public void BTN_Desactive()
    {
        ScreenManager.instance.DesactiveScreen(newWindow);

    }
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Desactivate()
    {
        gameObject.SetActive(false);
    }

    public void Hide()
    {
        var c = GetComponent<Image>().color;
        GetComponent<Image>().color = new Color(c.r, c.g, c.b, 0.5f);
    }
}
