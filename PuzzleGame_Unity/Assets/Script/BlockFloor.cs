using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFloor : MonoBehaviour
{
    public GameObject blockPrefab;
    public int start_X_Position;
    public int start_Z_Position;
    private Rigidbody rb;
    public int xVel;
    public int zVel;
    // Start is called before the first frame update
        void OnCollisionEnter(Collision coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Player")){
            Invoke("ActivateBlock", 1f);
        }
            
    }

    void ActivateBlock()
    {
        GameObject block = Instantiate<GameObject>(blockPrefab);
        rb = block.GetComponent<Rigidbody>();
        block.transform.position = new Vector3(start_X_Position, 5, start_Z_Position);
        rb.velocity = new Vector3(xVel, 0, zVel);
    }
}
