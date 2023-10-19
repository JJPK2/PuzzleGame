using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayTimer : MonoBehaviour
{
    static public TextMeshProUGUI uiText;
    //uiText.gameObject.SetActive(boolean) 
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = TimerFloorScript.GetTime();
    }
}
