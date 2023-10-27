using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class OnClickSwitchState : MonoBehaviour
{
    public InputActionAsset actions;

    void OnEnable(){
        actions.FindActionMap("MouseControlActionMap").Enable();
        actions.FindActionMap("MouseControlActionMap").FindAction("Left Mouse Click Confirm").performed += OnMouseDown;
    }
    void OnDisable(){
        actions.FindActionMap("MouseControlActionMap").Disable();
        actions.FindActionMap("MouseControlActionMap").FindAction("Left Mouse Click Confirm").performed -= OnMouseDown;
    }

    void OnMouseDown()
    {
        
    }
}
