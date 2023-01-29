using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        // if (collision.gameObject.name == "Cell")
        // {
        //     // if (collision.gameObject.GetStatus == true){
             Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), this.GetComponent<BoxCollider2D>());
        //     // }
        // }
    }
    
    void OnCollisionStay(Collision collision){
        Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), this.GetComponent<BoxCollider2D>());
    }
}
