using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text uiText;
    //[SerializeField] private float mainTimer;
    //private TMP_Text uiText;

    private float timer;
    private static bool start = true;
    private bool stop = false;

    public void Start()
    {
        timer = 0.0f;
        uiText.text = timer.ToString("F");
    }

    void Update()
    {
        //timer += Time.deltaTime;
        //Debug.Log(timer);
        //uiText.text = timer.ToString("F");
        if (start)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        /*while (!stop)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            uiText.text = timer.ToString("F");
        }*/
        /*if(timer <= 0.0f && start)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            uiText.text = timer.ToString("F");
        }*/
        /*else if (timer >= 0.0f && !stop)
        {
            start = false;
            stop = true;
            //uiText.text = "0.00";
            //timer = 0.0f;
        }*/
    }

    public void End()
    {
        start = false;
        stop = true;
    }
}
