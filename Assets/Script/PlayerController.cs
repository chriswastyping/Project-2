using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerManager();
    }

    void PlayerManager()
    {
          // Player Control

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange)
        {
            NegativeRange();
        }

        if(transform.position.x > xRange)
        {
            PositiveRange();
        }

        // Projectile

        if (Input.GetKeyDown(KeyCode.Space))
        {
           LaunchProjectile();
        }
    }

    void NegativeRange()
    {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    void PositiveRange()
    {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    void LaunchProjectile()
    {
         // Launch Projectile from player
            // Instantiate creates a copy of an object
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
