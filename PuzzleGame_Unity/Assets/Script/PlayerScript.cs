using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update7
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && rb.velocity.y == 0) {
            rb.velocity = new Vector3(rb.velocity.x, 5, 9.85f);
        }
        if(Input.GetKeyDown(KeyCode.A) && rb.velocity.y == 0) {
            rb.velocity = new Vector3(-9.85f, 5, rb.velocity.z);
        }
        if(Input.GetKeyDown(KeyCode.S) && rb.velocity.y == 0) {
            rb.velocity = new Vector3(rb.velocity.x, 5, -9.85f);
        }
        if(Input.GetKeyDown(KeyCode.D) && rb.velocity.y == 0) {
            rb.velocity = new Vector3(9.85f, 5, rb.velocity.z);
        }

    }

    void OnCollisionEnter(Collision coll){
        //GameObject collidedWith = coll.gameObject;
        if(coll.gameObject.layer == 7){
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
    
}
