using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayASoundOnClick : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hover;
    public AudioClip confirm;

    [HideInInspector]
    public MouseControl MouseIsHovering;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MouseIsHovering == true){
            source.PlayOneShot(hover);
        }
        if (Input.GetMouseButtonDown(0)) {
            //Source.clip = Confirm;
            source.PlayOneShot(confirm);    //if not using GetMouseButtonDown but just GetMouseButton and I'd use .Play(), it will play at every frame. But it works one time if I use PlayOneShot(Confirm);
        }
    }
}
