using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public int Value = 1;
    private PlayerBehaviour player;
    [HideInInspector]
    public bool toTarget = false;
   
    private void Start(){
        player = FindObjectOfType<PlayerBehaviour>();
    }
    public void ToTarget()
    {
        transform.position = Vector2.Lerp(transform.position, player.transform.position, 2f*Time.deltaTime);
    }
    public void Update()
    {
        if (toTarget)
            ToTarget();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Gm is here");
            GameManager.Gm.Collect(Value);
            Destroy(gameObject);
        }
    }

    //public void OnBecameVisible() {
    //playerBehaviour.GameObjectsinView.Add(gameObject);

    //}
    //public void OnBecameInvisible() {
    //playerBehaviour.GameObjectsinView.Remove(gameObject);        
    //}
    
    void PlayAudio()
    {
        GetComponentInParent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("CoinsSound/Coin1"));
    }
}
