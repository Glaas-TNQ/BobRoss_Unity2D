using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{   
    private Vector3 facingDirection;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    void Update(){
        if (Input.GetKey(KeyCode.Space))
            {
            Transform playerTransform = this.transform;
            // Get the forward vector of the player's local space
            facingDirection = playerTransform.forward;
             // Create a new projectile object
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

            // Get the Rigidbody2D component of the projectile
            Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

            // Calculate the direction the player is facing
            Vector2 direction = new Vector2(Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad),
                                            Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad));

            // Apply velocity to the projectile based on the direction the player is facing
            projectileRb.velocity = facingDirection * projectileSpeed;
        }
    } 
}
