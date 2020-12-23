using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    [SerializeField]
    private int StartCountDown = 60;

    [SerializeField]
    Text TxtCountDown;

    void Start()
    {

        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (StartCountDown > 0)
        {
            yield return new WaitForSeconds(1f);
            StartCountDown--;
            TxtCountDown.text = "TimeLeft : " + StartCountDown;
        }

        Debug.Log("You're dead");
    }



}


