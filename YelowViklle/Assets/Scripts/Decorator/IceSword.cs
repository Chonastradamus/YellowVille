using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSword : SwordDecorator
{

    public IceSword (Sword swr)
    {
        _swr = swr;
    }

    public override string GetDescrition()
    {
        return _swr.GetDescrition() + ",Ice";
    }

    public override int Hit()
    {
        return _swr.Hit() + 5;
    }

    
}
