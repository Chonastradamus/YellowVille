using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MagicDecorator : Magic
{
    protected Magic _magic;
    public override Magic Add()
    {
        return _magic;
    }
}
