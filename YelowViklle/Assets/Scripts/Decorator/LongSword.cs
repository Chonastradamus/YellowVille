using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongSword : Sword
{
    public LongSword(string description)
    {
        _description = description;
    }
    public override string GetDescrition()
    {
        return _description;
    }

    public override int Hit()
    {
        return 15;
    }
    public override Sword Remove()
    {
        return this;
    }
}
