using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_One : MonoBehaviour
{
    public GameObject[] SkinAnimator;
    public Animator[] animatorPlayer;
    public int AnimID;
    public float speed;
    public FloatingJoystick FJostic;
    public Rigidbody rb;
    public void Start()
    {
        // Проверка на включенный скин для подключения анимации
        for(int i = 0; i < SkinAnimator.Length; i++)
        {
            if (SkinAnimator[i].activeSelf)
            {
                AnimID = i;
            }
        }
    }
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
            animatorPlayer[AnimID].Play("Thyra_Run");
        }
        else if (FJostic.Horizontal == 0 && FJostic.Vertical == 0)
        {
            animatorPlayer[AnimID].Play("Thyra_Idle");
        }
    }
}
