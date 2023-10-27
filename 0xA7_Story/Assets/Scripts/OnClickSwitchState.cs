using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnClickSwitchState : MonoBehaviour
{
    public StateMachine stateMachine;
    public StateMachine.StoryState buttonState;


    public void clickToSwitch()
    {
        stateMachine.state = buttonState;
        stateMachine.SwitchState();
    }

}
