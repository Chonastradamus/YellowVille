using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosier : Magic
{
    public Crosier(string description)
    {
        _description = description;
    }

  
    public override string GetDescrition()
    {
        return _description;
    }

    public override int Power()
    {
        return 5;
    }
    public override Magic Add()
    {
        return this;
    }



}
