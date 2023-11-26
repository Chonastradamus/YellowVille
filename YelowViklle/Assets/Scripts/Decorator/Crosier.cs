using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosier : Magic
{
    Magic _magic;
    public Crosier(Magic mg)
    {
        _magic = mg;

    }
    public override int Power()
    {
        return 5;
    }

}
