using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPBlockScript : MonoBehaviour
{
    public GameObject playerTP;
    public int x_Position;
    public int z_Position;
    private Rigidbody rb;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Player")){
            playerTP.transform.position = new Vector3(x_Position, 3, z_Position);
        }
    }
}
