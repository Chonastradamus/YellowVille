using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View
{
    private Renderer _renderer;
    public Material onMoveMaterial;
    //private Animator _anim;

    public View(Renderer renderer, Controller controller)
    {
        _renderer = renderer;
        //_anim = anim;
        controller.onMovement += OnMove;
    }

    private void OnMove(float horizontal, float vertical)
    {
        if (horizontal != 0 || vertical != 0)
        {
            _renderer.material.color = Color.blue;
            //_anim.SetBool("Runnning", true);
        }
        else
        {
            _renderer.material.color = Color.green;
            //_anim.SetBool("Runnning", false);
        }
    }

    void Ondamage()
    {
        _renderer.material.color = Color.red;


    }
}
