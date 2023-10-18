using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingLvl : MonoBehaviour
{
    public int start_X_Position;
    public int start_Z_Position;
    public GameObject playerStart;

    public int currentLvl;
    // Start is called before the first frame update
    void Start()
    {
        playerStart.transform.position = new Vector3(start_X_Position, 3, start_Z_Position);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStart.transform.position.y <= -20f){
            //playerStart.transform.position = new Vector3(start_X_Position, 3, start_Z_Position);
            SceneManager.LoadScene("Level_" + currentLvl);
        }   
    }
}
