using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortSword : Sword
{
    public override string GetDescrition()
    {
        return _description;
    }

    public override int Hit()
    {
        return 5;
    }
    public override Sword Remove()
    {
        return this;
    }

}
