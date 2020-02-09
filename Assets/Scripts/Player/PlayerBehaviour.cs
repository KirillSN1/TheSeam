using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerBehaviour : MonoBehaviour
{
    public float Speed = 4;
    public float JumpingVelocity;
    public float MInput;
    public float FallAccelerationValue = 1.055f;
    public float AccelerationPower;
    public float AccelerationTime = 6f;
    public float DecelerationTime = 6f;
    public Transform Feet;
    public float feetRadius;
    public LayerMask Groundlayer;
    public bool isGrounded = false;
    public Rigidbody2D rb;
    public Animator Anim;
    public float animoffset;

    public void Start()
    {
        //Anim = GetComponent<Animator>();
    }
    private void Update()
    {
        AnimationController();
    }

    public void AnimationController()
    {
        Anim.SetFloat("Speed", Mathf.Abs(MInput));
        Anim.SetFloat("JumpVeloc", rb.velocity.y);
        Anim.speed = Speed / animoffset;
        Anim.SetBool("isGrounded", isGrounded);
    }
}
