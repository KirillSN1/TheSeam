using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public PlayerBehaviour player;
    
    void Update()
    {
        Walk();

        if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded)
        {
            Jump();
        }
    }

    public void Walk()
    {
        player.MInput = Input.GetAxis("Horizontal");
        player.rb.velocity = new Vector2(player.MInput * player.Speed, player.rb.velocity.y);

        player.isGrounded = Physics2D.OverlapCircle(player.Feet.position, player.feetRadius, player.Groundlayer);
    }

    public void Jump()
    {
        player.rb.velocity = Vector2.up * player.JumpingVelocity * 3;
        if (player.rb.velocity.y < 0)
        {
            player.rb.velocity = new Vector2(player.rb.velocity.x, player.rb.velocity.y * player.FallAccelerationValue);
        }
    }
}
    

    
  

