using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTimer : MonoBehaviour
{

    public float timeLeft;
    public bool timerOn = false;
    public Text timerText;


    // Start is called before the first frame update
    void Start()
    {
        timerOn = true; //  upon start the timer is on
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn) // condition
        {
            if(timeLeft > 0) // Bit of a failsafe. 
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else // otherwise if the time left is 0 then the timer on boolean becomes false.
            {
                Debug.Log("Time Is Up!");
                timeLeft = 0;
                timerOn = false;
            }
        }
        
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60); // returns the largest integer currently assigned to currentTime float
        float seconds = Mathf.FloorToInt(currentTime % 60); // as above but the remainder of the whole numbers - or the seconds

        timerText.text = currentTime.ToString("0.0"); // currentTime float converted to string for display
    }
}
