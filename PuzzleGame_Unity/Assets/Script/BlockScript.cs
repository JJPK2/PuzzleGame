using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Wall")){
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
        }
        if(collidedWith.CompareTag("Player")){
            Invoke("RestartScene", 1f);
        }
    }

    void RestartScene(){
        TimerFloorScript.resetTime();
        TimerFloorScript.startCountDown = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
