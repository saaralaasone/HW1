using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += OnLightToggle();
    }

    private void OnLightToggle(InputAction.CallbackContext ctx)
    {
        if (light.color == Color.white)
            light.color = Color.red;
        else
            light.color = Color.white;
    }
    
    void OnDestroy()
    {
        action.action.performed -= OnLightToggle;
    }
}
