using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour,Idamagable
{
    Controller controller;
    View _view;
    [SerializeField] Renderer _renderer;
    [SerializeField] float life;
    [SerializeField] float Speed;


    void Start()
    {
        controller = new(this);
        controller.onMovement += Move;
        _view = new(_renderer, controller);
    }

    void Update()
    {
        controller.onUpdate();
    }
    public void TakeDamage(float dmg, float life)
    {
        life = -dmg;
    }

    public void Move(float horizontal, float vertical)
    {

        transform.position += new Vector3(horizontal, 0, vertical) * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            
        }
    }
}
