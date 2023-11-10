using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDown = 5f;
    private float coolDownTimer = 0f;  // Initialize the timer to 0

    // Update is called once per frame
    void Update()
    {
        // Decrease the cooldown timer in each frame
        coolDownTimer -= Time.deltaTime;

        // On spacebar press and when the cooldown timer has elapsed
        if (Input.GetKeyDown(KeyCode.Space) && coolDownTimer <= 0)
        {
            // Instantiate the dogPrefab
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Reset the cooldown timer to the cooldown duration
            coolDownTimer = coolDown;
            
        }
        
    }

    
}
