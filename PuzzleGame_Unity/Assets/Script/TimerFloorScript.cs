using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerFloorScript : MonoBehaviour
{
    static public float timeCountDown = 22.0f;
    static public bool startCountDown = false;
    public GameObject showTimer; 
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(startCountDown == true){
            timeCountDown -= Time.deltaTime;
        }
        if(timeCountDown < 0){
            timeCountDown = 22.0f;
            startCountDown = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(startCountDown){
            Debug.Log("Heh");
            showTimer.gameObject.SetActive(true);
        } else{
            showTimer.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Player")){
            startCountDown = true;
        }

    }

    static public string GetTime()
    {
        return timeCountDown.ToString("00");
    }
    
    static public void resetTime()
    {
        timeCountDown = 22.0f;
    }

    static public bool getStartCountDown()
    {
        return startCountDown;
    }
}
