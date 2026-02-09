using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifying : MonoBehaviour
{
    public Transform mainCamera;
    public Transform lens;
    void LateUpdate()
    {
        transform.position = lens.position;
        Vector3 dir = lens.position - mainCamera.position;
        Vector3 target = lens.position + dir;
        transform.LookAt(target, Vector3.up); //change to vector3.up or lens.up
    }
}
