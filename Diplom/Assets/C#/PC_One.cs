using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_One : MonoBehaviour
{
    public float speed;
    public FloatingJoystick FJostic;
    public Rigidbody rb;
    public void Update()
    {
        MovePlayer();
    }
    public void MovePlayer()
    {
        rb.velocity = new Vector3(FJostic.Horizontal * speed, rb.velocity.y, FJostic.Vertical * speed);

        if(FJostic.Horizontal != 0 ||  FJostic.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }
}
