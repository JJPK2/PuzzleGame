using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushFloor : MonoBehaviour
{
    public GameObject playerPushed;
    public float xVel;
    public float zVel;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = playerPushed.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Player")){
            rb.velocity = new Vector3(xVel, 5, zVel);
        }
    }
}
