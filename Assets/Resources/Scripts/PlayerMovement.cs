using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 moveDirection;
    private Rigidbody2D rigidbody2D;
    private const float moveSpeed = 5f;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;


        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        moveDirection = new Vector3(moveX, moveY).normalized;
        
    }





    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDirection * moveSpeed ;

    }





}
