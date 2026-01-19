using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float degreesPerSecond = 1.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f);
    }
}
