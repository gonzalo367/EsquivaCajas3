using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour

{
    public float speed = 2f;
    float initialYValue;

    // Start is called before the first frame update
    void Start()
    {
         initialYValue = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed * Time.deltaTime ,0);
    }
    public void MoveBoxToRandomPosition()
    {
    
        //PARA PROBAR, SOLAMENTE HACEMOS QUE SUBA
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;

    }
}
