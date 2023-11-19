using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSword : SwordDecorator
{
    public FireSword(Sword swr)
    {
        _swr = swr;
    }   

    public override string GetDescrition()
    {
        return _swr.GetDescrition() + ",Fire";
    }

    public override int Hit()
    {
        return _swr.Hit() + 7;
    }
    
}
