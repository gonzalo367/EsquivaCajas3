using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Caja"))
        { 
            Gamemanager gm = FindObjectOfType<Gamemanager>();
            
            if (gm != null) 
            {
                gm.DetenerReloj();
            }

            Destroy(gameObject);
        }
    }
}