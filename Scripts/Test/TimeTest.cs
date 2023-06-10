using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    private void Start()
    {
        int seconds = 7521;
        string formattedTime = solution(seconds);
        Debug.Log(formattedTime);

        seconds = 836;
        formattedTime = solution(seconds);
        Debug.Log(formattedTime);

        seconds = 43;
        formattedTime = solution(seconds);
        Debug.Log(formattedTime);
    }

    public string solution(int X)
    {
        int hours = X / 3600;
        int minutes = (X % 3600) / 60;
        int seconds = X % 60;

        string result = "";

        if (hours > 0)
            result += hours + "h";

        if (minutes > 0)
            result += minutes + "m";

        if (seconds > 0 && hours <= 0)
            result += seconds + "s";

        return result;
    }
}
