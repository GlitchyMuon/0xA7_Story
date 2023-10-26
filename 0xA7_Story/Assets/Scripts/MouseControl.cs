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

    // Start is called before the first frame update
    void Start()
    {
        clickableSprite = GetComponent<SpriteRenderer>().sprite;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
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
        if (MouseIsHovering == true) {
            IsClicked = true;
           //manager.FaceUp(this); -> remplacer par une fonction Coroutine qui gérera les états, l'animation, dans un manager, dont on a besoin ici
        } //le paramètre c'est le MouseControl actuel donc this
    }
}
