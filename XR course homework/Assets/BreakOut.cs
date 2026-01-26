using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform externalViewPoint;
    public InputActionReference action;
    private Vector3 roomPosition;
    private Quaternion roomRotation;
    private bool isOutside = false;
    void Start()
    {
        roomPosition = transform.position;
        roomRotation = transform.rotation;
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (!isOutside)
            {
                transform.position = externalViewPoint.position;
                transform.rotation = externalViewPoint.rotation;
                isOutside = true;
            }
            else
            {
                transform.position = roomPosition;
                transform.rotation = roomRotation;
                isOutside = false;
            }
        };
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}