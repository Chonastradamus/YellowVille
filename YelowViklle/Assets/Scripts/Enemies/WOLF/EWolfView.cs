using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;

public class EWolfView 
{
     Renderer _renderer;
    // Material _basemateiral;
     //Material _sleepMaterial;
    Material[] _Materials;

    /*    public EWolfView( Renderer renderer, Material[] materials,Ewolf controler)
        {

            _Materials = materials;
            controler.Detection += HasDetected;
        }*/


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


