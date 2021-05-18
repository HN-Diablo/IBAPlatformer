using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMov : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D r2D;
    private SpriteRenderer SPR;


    // Start is called before the first frame update
    void Start()
    {
        r2D = GetComponent<Rigidbody2D>();
        SPR = GetComponent<SpriteRenderer>();
        r2D.velocity = new Vector2(moveSpeed, r2D.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("cRight"))
        {
            r2D.velocity = new Vector2(-moveSpeed, r2D.velocity.y);
            if (SPR.flipX == true) 
            SPR.flipX = false;
            else SPR.flipX = true;
        }   
        else if (other.gameObject.CompareTag("cLeft"))
        {
            r2D.velocity = new Vector2(moveSpeed, r2D.velocity.y);
            if (SPR.flipX == true) SPR.flipX = false;
            else 
            SPR.flipX = true;
        }


    }
}