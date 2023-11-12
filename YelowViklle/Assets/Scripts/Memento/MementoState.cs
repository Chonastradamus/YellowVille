using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoState 
{
    ParamsMemento data;

   public void Rec(params object[] parameters)
    {
        data = new ParamsMemento(parameters);

    }

      //public bool IsRemember() => data != null;
      public bool IsRemember()
    {
        return data != null;
    } 

    public ParamsMemento Remember()
    {
        var x = data;
        data = null;
        return x;
    } 
   
}
