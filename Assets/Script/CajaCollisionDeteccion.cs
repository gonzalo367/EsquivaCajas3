using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDeteccion : MonoBehaviour
{
    public CajaMovement CajaMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        CajaMovementScript = GetComponent<CajaMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        { 
            CajaMovementScript.MoveBoxToRandomPosition();
        }
        }
}
