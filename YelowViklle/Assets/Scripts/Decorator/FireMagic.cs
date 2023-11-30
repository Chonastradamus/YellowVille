using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMagic : MagicDecorator
{

    public FireMagic (Magic mg)
    {
        _magic = mg;

    }
   

    public override int Power()
    {
        return _magic.Power() + 5;
    }


}
