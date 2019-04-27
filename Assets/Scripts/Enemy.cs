using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Transform target;
    private bool readyToAttack = true;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 5f && Vector2.Distance(transform.position, target.position) >= 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if(Vector2.Distance(transform.position, target.position) <= 1f)
        {
            if (readyToAttack)
            {
                StartCoroutine(damagePlayer());
            }
        }
        
    }

    private IEnumerator damagePlayer() {
        readyToAttack = false;
        //Debug.Log("Player damaged!");
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().takeDamage(10);
        yield return new WaitForSeconds(1f);
        readyToAttack = true;
    }
}
