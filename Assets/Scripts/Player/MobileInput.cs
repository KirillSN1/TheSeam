using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MobileInput : MonoBehaviour
{
    private PlayerBehaviour player;

    private float MInput;
    private bool left;
    private bool right;
    private KeyboardInput kInput;

    private void Start()
    {
        player = GetComponent<PlayerBehaviour>();
    }

    private void Update()
    {
        //if (left)
        //{
        //    MInput = -1;
        //}
        //if (left==false && right==false)
        //{
        //    MInput = 0;
        //}
        //if (right)
        //{
        //    MInput = 1;
        //}
        //player.MInput = MInput;
    }

    //public void LeftDown()
    //{
    //    left = true;
    //    player.Acc = true;
    //    player.runDir = player.MInput;
    //}
    //public void LeftUp()
    //{
    //    left = false;
    //    player.Acc = false;
    //    player.runDir = player.MInput;
    //}

    //public void RightDown()
    //{
    //    right = true;
    //    player.Acc = true;
    //    player.runDir = player.MInput;
    //}

    //public void RightUp()
    //{
    //    right = false;
    //    player.Acc = false;
    //    player.runDir = player.MInput;
    //}

    public void Jump()
    {
        if (player.isGrounded)
        {
            player.rb.velocity = Vector2.up * player.JumpingVelocity * 3;
            if (player.rb.velocity.y < 0)
            {
                player.rb.velocity = new Vector2(player.rb.velocity.x, player.rb.velocity.y * player.FallAccelerationValue);
            }
        }
    }

    //public void Attack()
    //{
    //    if (player.Anim.GetBool("Attack") == false)
    //    {
    //        player.DetectEnemy();
    //    }
    //}

    //public void SwitchUp()//Переход между платформами
    //{
    //    if (player.isGrounded && !player.isOnSky)
    //    {
    //        player.rb.velocity = Vector2.up * player.platformJump * 3.5f;

    //        if (player.currentPlatform != null)
    //        {
    //            player.currentPlatform.enabled = true;
    //        }
    //        Debug.Log("Up");
    //    }
    //}
    //public void SwitchDown()//Переход между платформами
    //{
    //    if (player.isGrounded && player.isOnSky)
    //    {
    //        if (player.currentPlatform != null)
    //        {
    //            player.currentPlatform.enabled = false;
    //        }
    //        Debug.Log("Doun");
    //    }
    //}

}
