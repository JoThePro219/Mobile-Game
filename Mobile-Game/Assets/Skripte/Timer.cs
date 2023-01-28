using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool active = false;
    float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        currentTimeText.text = "0:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        else
        {
            return;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
  
        currentTimeText.text = time.Minutes.ToString() + ":" +time.Seconds.ToString() + "." +time.Milliseconds.ToString();
    }

    public void StartTimer()
    {
        active = true;
    }

    public void EndTimer()
    {
        active = false;
        currentTimeText.color = Color.yellow;
    }

    public void ResetTimer()
    {
        currentTime = 0;
        currentTimeText.text = "0:00.00";
        active = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Killer"))
        {
            active = false;
            currentTimeText.color = Color.red;
        }
    }
}
