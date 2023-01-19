using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    public Rigidbody2D myRigidBody;

    Vector2 movement; // stores x and y values from
    // movement

    // Update is called once per frame

    // Don't put physics related things in update
    // put it in fixed update instead as your
    // frame rate can constantly change
    // this includes movement

    void Update()
    {
        // Movement Input

        movement.x = Input.GetAxisRaw("Horizontal"); // Horizontal Input
        // left = - 1 right = 1

        movement.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
        // Movement Physics

        // moves rigidbody attached to object
        // to new location based on movement
        myRigidBody.MovePosition(myRigidBody.position + movement * movementSpeed * Time.fixedDeltaTime);

        // Multiply by Time.fixedDeltaTime so we can have constant movement speed
        // this is the amount of time since the last time this "move position" function is called

    }
}
