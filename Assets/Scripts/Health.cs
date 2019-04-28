using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float health;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }


    public void Bought(float price)
    {
        health -= price;
    }

    public void Hit(float damage)
    {
        anim.SetTrigger("Hit");
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);

    }
    public float getHealth()
    {
        return health;
    }
}
