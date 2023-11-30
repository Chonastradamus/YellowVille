using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamsMemento
{
    public object[] paramameters;

    public ParamsMemento (params object [] p)
    {
        paramameters = p;
    }
}
