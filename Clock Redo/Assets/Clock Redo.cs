using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock2 : MonoBehaviour
{

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hourPivot, minPivot, secPivot;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        {
            hourPivot.localRotation =
                Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
            minPivot.localRotation =
                Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
            secPivot.localRotation =
                Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
        }
    }
}