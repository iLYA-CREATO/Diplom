using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_One : MonoBehaviour
{
    public Animator animatorPlayer;
    public float speed;
    public FloatingJoystick FJostic;
    public Rigidbody rb;
    public void FixedUpdate()
    {
        MovePlayer();
    }
    public void MovePlayer()
    {
        rb.velocity = new Vector3(FJostic.Horizontal * speed * Time.deltaTime, rb.velocity.y, FJostic.Vertical * speed * Time.deltaTime);

        if(FJostic.Horizontal != 0 ||  FJostic.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            animatorPlayer.Play("Thyra_Run");
        }
        else if (FJostic.Horizontal == 0 && FJostic.Vertical == 0)
        {
            animatorPlayer.Play("Thyra_Idle");
        }
    }
}
