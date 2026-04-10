using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        Debug.Log("Health collectible collided with " + other.name);
        Debug.Log("Player health before collecting: " + controller.health);
        Debug.Log("Player max health: " + controller.maxHealth);
        if (controller != null && controller.health< controller.maxHealth)
        {
            controller.ChangeHealth(1);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
        
    }
}