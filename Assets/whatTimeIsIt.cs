using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class whatTimeIsIt : MonoBehaviour
{
    [SerializeField] private const float htodeg = -30f, mtodeg = -6f, stodeg = -6f;
    [SerializeField] Transform hpivot, mpivot, spivot;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hpivot.localRotation = Quaternion.Euler(-(htodeg * (float)time.TotalHours), 0f, 0f);
        mpivot.localRotation = Quaternion.Euler(-(mtodeg * (float)time.TotalMinutes), 0f, 0f);
        spivot.localRotation = Quaternion.Euler(-(stodeg * (float)time.TotalSeconds), 0f, 0f);
    }
}
