using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifying : MonoBehaviour
{
    public Transform mainCamera;
    public Transform lens;
    void LateUpdate()
    {
        //Vector3 dir = (lens.position - mainCamera.position);
        //Vector3 up = lens.up;
        //transform.rotation = Quaternion.LookRotation(dir, up);
        //transform.position = lens.position - dir * 0.01f;
        transform.position = lens.position;
        Vector3 dir = (lens.position - mainCamera.position);
        //Vector3 forwardPoint = lens.position + (lens.position - mainCamera.position);
        Vector3 target = lens.position + dir;
        transform.LookAt(target, lens.up);
    }
}
