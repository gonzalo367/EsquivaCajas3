using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 2f;
    public float aumentoVelocidad = 0.5f;
    float initialYValue;
    Rigidbody rb;

    void Start()
    {
        initialYValue = transform.position.y;
        rb = GetComponent<Rigidbody>();
        

        if (rb != null) {
            rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        }
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    public void MoveBoxToRandomPosition()
    {
        speed += aumentoVelocidad;


        if (rb != null) {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        Vector3 newPosition = transform.position;
        int randomX = Random.Range(0, 3);

        if (randomX == 0) {
            newPosition.x = -2;
        } else if (randomX == 1) {
            newPosition.x = 0;
        } else {
            newPosition.x = 2;
        }

        newPosition.y = initialYValue;
        transform.position = newPosition;
        
    
        transform.rotation = Quaternion.identity;
    }
}