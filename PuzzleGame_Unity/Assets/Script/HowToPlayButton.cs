using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
