///using System.Collections;
///using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement Movement;
    public gameManagement gameManager;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag =="Obstacle")
        {
            Movement.enabled = false;
            FindObjectOfType<gameManagement>().EndGame();
        }
    }



    // Start is called before the first frame update
    ///void Start()
   /// {
        
  ///  }

    // Update is called once per frame
   /// void Update()
   /// {
        
    ///}
}
