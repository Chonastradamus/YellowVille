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

    [SerializeField] bool OnGround;
    [SerializeField] float JumpForce;
    [SerializeField] LayerMask Ground;

    [SerializeField] GameObject[] Particules;



    private void Awake()
    {
        OnGround = true;
    }
    void Start()
    {
        controller = new(this);
        controller.onMovement += Move;
        controller.OnJump += Jump;
        _view = new(_renderer, controller, Particules);
    }

    void Update()
    {
        controller.onUpdate();
    }
    public void TakeDamage(float dmg)
    {
        life = -dmg;

            if (life <= 0)
            {
            this.gameObject.SetActive(false);
            }
        
    }

    public void Move(float horizontal, float vertical)
    {

        transform.position += new Vector3(horizontal, 0, vertical) * Speed * Time.deltaTime;
    }
    public void Jump(float Jump)
    {
       
            transform.position += new Vector3(0, Jump, 0) * JumpForce * Time.deltaTime;
        OnGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            OnGround = true;
        }
    }


}
