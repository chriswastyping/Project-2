using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zRangeP = 14.0f;
    public float zRangeN = 0.0f;

    public GameObject projectilePrefab;
    public Vector3 offsetPos = new Vector3(0, 0, 2);

    // Update is called once per frame
    void Update()
    {
        PlayerManager();
    }

    void PlayerManager()
    {
        // Player Controls
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Combines the inputs into a single vector
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // Move the player
        transform.Translate(movement * Time.deltaTime * speed);

        // POSITION BOUNDARY
        // Used Vector3.ClampMagnitude 
        float clampedX = Mathf.Clamp(transform.position.x, -xRange, xRange);
        float clampedZ = Mathf.Clamp(transform.position.z, -zRangeN, zRangeP);

        // Update the player's position
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);

        // Projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile();
        }
    }

    void LaunchProjectile()
    {
        // Launch Projectile from player
        // Instantiate Makes a copy

        Instantiate(projectilePrefab, transform.position + offsetPos, projectilePrefab.transform.rotation);
    }
}
