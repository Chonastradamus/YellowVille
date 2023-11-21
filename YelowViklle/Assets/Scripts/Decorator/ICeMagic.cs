using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICeMagic : MagicDecorator
{
    public ICeMagic(Magic magic)
    {
        _magic = magic;

    }
    public override string GetDescrition()
    {
        return _magic.GetDescrition() + ",Ice";
    }

    public override int Power()
    {
        return _magic.Power() + 10;
    }
    

}
