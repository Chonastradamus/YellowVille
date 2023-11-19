using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwordDecorator : Sword
{
    protected Sword _swr;

    //removemos cuando llamamos al codigo  la espada original
    public override Sword Remove()
    {
        return _swr;
    }


}
