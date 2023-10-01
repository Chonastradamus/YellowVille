using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;

public class EWolfView 
{
    //tp1 Juan Guastini
     Renderer _renderer;
    Material[] _Materials;
    #region BuilderSetThings
    public EWolfView SetControler(Ewolf controler)
    {
        controler.Detection += HasDetected;

        return this;
    }
    public EWolfView SetRenderer(Renderer renderer)
    {
        _renderer = renderer;

        return this;
    }
    public EWolfView SetArrayMaterials(Material[] materials)
    {
        _Materials = materials;

        return this;
    }
    #endregion

    public void HasDetected(bool detected)
    {
        if (!detected)
        {
             _renderer.material = _Materials[0];
           
        }
        else
        {
            _renderer.material = _Materials[1] ;
           
        }
    }

  


}


