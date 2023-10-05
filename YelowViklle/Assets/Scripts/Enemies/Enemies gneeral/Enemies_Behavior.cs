using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  abstract class Enemies_Behavior : MonoBehaviour,Idamagable
{
    //tp1 Juan Guastini
    [Header("Movement")]
    [SerializeField] Rigidbody _rb;
    [Header("Detecction")]
    [SerializeField] public float checkRadius;
    public LayerMask whatIsPlayer;
    public Transform[] target;
    [SerializeField] public bool IsInChaseRange;
    [Header("Life")]
    public float life;
    [SerializeField] Idamagable idamagable;
    [Header("rune")]
    public float Timechase;


    private void Awake()
    {
        life = FlyweightPointer.enemies.Maxlife;
    }

    protected virtual void Update()
    {
       detection();
    }

    public void detection()
    {
        IsInChaseRange = Physics.CheckSphere(transform.position, checkRadius, whatIsPlayer);
    }


    protected virtual void FixedUpdate()
    {
        if (IsInChaseRange)
        {
            MoveEnemies();
        }
    }

    public virtual void aviso(params object[] parameter)
    {       
        MoveEnemies();  
    }

    void MoveEnemies()
    {
        transform.Translate(Vector3.forward * FlyweightPointer.enemies.speed * Time.deltaTime);
        Vector3 direction = target[0].position - transform.position;
        direction.y = 0; // Para evitar movimientos verticales
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
    }

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

    public void TakeDamage(float dmg)
    {
        life -= dmg;
        print("golpeo");

        if (life <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private IEnumerator Llamadoplayer()
    {
        IsInChaseRange = true;

        yield return new WaitForSeconds(Timechase);

        IsInChaseRange = false;
    }
}
