using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class MouseControl : MonoBehaviour
{
    public Sprite clickableSprite;
    private Animator animator;
    public InputActionAsset actions;

    private bool _mouseIsHovering;

    public bool MouseIsHovering {
        get {return _mouseIsHovering;}
        set 
        { 
            _mouseIsHovering = value;
            animator.SetBool("mouseIsHovering", value);
        }
    }

    private bool _isClicked;

    public bool IsClicked {
        get {return _isClicked;}
        set 
        {
            Debug.Log($"{name} {value}");
            _isClicked = value;
            animator.SetBool("isClicked", value);
        }
    }


    void Start()
    {
        clickableSprite = GetComponent<SpriteRenderer>().sprite;
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        
    }

    void OnEnable(){
        actions.FindActionMap("MouseControlActionMap").Enable();
        actions.FindActionMap("MouseControlActionMap").FindAction("Left Mouse Click Confirm").performed += OnMouseClicked;
    }
    void OnDisable(){
        actions.FindActionMap("MouseControlActionMap").Disable();
        actions.FindActionMap("MouseControlActionMap").FindAction("Left Mouse Click Confirm").performed -= OnMouseClicked;
    }

    void OnMouseClicked(InputAction.CallbackContext context)
    {
        if (MouseIsHovering == true) 
        {
            IsClicked = true;          
        } 
    }

}
