using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light lights;
    public InputActionReference action;
    void Start()
    {
        lights = GetComponent<Light>();
        //action.action.Enable();
        //action.action.performed += OnLightToggle();
    }

    private void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (lights.color == Color.white)
                lights.color = Color.red;
            else
                lights.color = Color.white;
        }
    }
}
