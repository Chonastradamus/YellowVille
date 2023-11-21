using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public abstract class Magic
{
    protected string _description;
    public abstract string GetDescrition();
    public abstract int Power();

    public abstract Magic Add();
}
