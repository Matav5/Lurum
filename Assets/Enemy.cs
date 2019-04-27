using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Transform target;
    private float origY;
    private float posX;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        origY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 5)
        {
            if (transform.position.x == target.position.x)
            {
                posX = transform.position.x;
                transform.position = new Vector2(posX < target.position.x ? ++posX : --posX, transform.position.y);
                
            }
        }
    }
}
