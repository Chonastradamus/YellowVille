using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sword
{
    
    protected string _description;
    public abstract string GetDescrition();
    public abstract int Hit();


    //remover 
    public abstract Sword Remove();     

    
}
