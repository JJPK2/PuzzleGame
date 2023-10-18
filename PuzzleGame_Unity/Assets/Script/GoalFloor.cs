using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalFloor : MonoBehaviour
{
    // Start is called before the first frame update
    public int nextLvl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Player")){
            SceneManager.LoadScene("Level_" + nextLvl);
        }
    }
}
