using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakWallTrigger : MonoBehaviour
{
    public GameObject breakWall;
    void OnTriggerEnter(Collider coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.layer == 9){
            Destroy(breakWall);
            Destroy(this.gameObject);
        }
    }
}
