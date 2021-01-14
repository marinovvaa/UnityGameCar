using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BackAndForward();
        Turns();
        Jump();
    }

    private void BackAndForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddRelativeForce(Vector3.forward);
        }
        else if(Input.GetKey(KeyCode.S))
            {
            rigidBody.AddRelativeForce(Vector3.back); //????????

             }
    }

    private void Turns()
    {
        rigidBody.freezeRotation = true;
       
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddRelativeForce(Vector3.right);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddRelativeForce(Vector3.left);

        }
        rigidBody.freezeRotation = false; //resume physics control of rotation
    }

    private void Jump()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);

        }
    }
}
