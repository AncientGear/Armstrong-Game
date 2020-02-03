using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    float currentTime;
    public float startTime;
    private bool paused = false;

    public Text countdownText;
     public Text wintext;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(paused == false){
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {
            currentTime = 0;
             wintext.text = "GameOver";
            }

        }
        else{
            currentTime = currentTime;
        }

    }
    public void AddBonusTime(float bonusTime)
    {
        currentTime += bonusTime;
    }

    public void PauseToggle()
    {
        if(paused== true){ 
            paused = false; 
        }
        else
        {
            paused = true;
        }
    }
}

