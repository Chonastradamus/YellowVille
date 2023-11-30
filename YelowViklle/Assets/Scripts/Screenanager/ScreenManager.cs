using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public Stack<Iscreen> Screns = new();

    public static ScreenManager instance;

    private void Awake()
    {
        instance = this;
            
    }
    public void ActiveScreen(Iscreen x) 
    {
        x.Activate();
       if (Screns.Count >0)
        {
            Screns.Peek().Hide();
        }
        //agrega al stack variables
        Screns.Push(x);
    }

   public void DesactiveScreen(Iscreen x)
    {
        //busca si hay pantallas
        if (Screns.Count > 0)
        {
            Screns.Pop().Desactivate();
            // agarra y lo activa
             if (Screns.Count > 0)
                 {
                //da la informacion co peek
                Screns.Peek().Activate();
                 }
        }

    }


}
