using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        print(animator);
    }

    // Update is called once per frame


    public void Attack()
    {
        print("hey");
        animator.SetTrigger("Attack");
    }

}
