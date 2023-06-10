using System;
using UnityEngine;

public class Solution : MonoBehaviour
{
    private void Start()
    {
        print(solution("12:01", "12:44")); // should return 1
        print(solution("20:09", "06:00")); // should return 40
        print(solution("00:00", "23:59")); // should return 95
        print(solution("12:03", "12:03")); // should return 0
    }

    public int solution(string A, string B)
    {
        TimeSpan startTime = TimeSpan.Parse(A);
        TimeSpan endTime = TimeSpan.Parse(B);

        if (endTime < startTime)
        {
            endTime = endTime.Add(new TimeSpan(24, 0, 0));
        }

        if (startTime.Minutes % 15 != 0)
        {
            startTime = startTime.Add(new TimeSpan(0, 15 - startTime.Minutes % 15, 0));
        }

        if (endTime.Minutes % 15 != 0)
        {
            endTime = endTime.Subtract(new TimeSpan(0, endTime.Minutes % 15, 0));
        }

        int totalQuarters = (int)(endTime.TotalMinutes - startTime.TotalMinutes) / 15;

        return totalQuarters;
    }
}