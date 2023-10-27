using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine.UI;
using Unity.VisualScripting;


public class StateMachine : MonoBehaviour
{
    public enum StoryState{
        Start,
        Hear,
        Invite,
        Follow,
        Radio,
        Temperature,
        See,
        Bike,
        Scream,
        Left,
        Right,
        Open1,
        Open2
    }

    public StoryState state;
    public JSONReaderSymboles text;
    
    [SerializeField]
    private TMP_Text webdingsTextStory;

    [SerializeField]
    private TMP_Text webdingsTextOption1;

    [SerializeField]
    private TMP_Text webdingsTextOption2;

    public OnClickSwitchState leftButton;
    public OnClickSwitchState rightButton;

    public AudioSource ambientMusicSciFi;
    public AudioSource ambientMusicHorror;

    void Start()
    {
        state = StoryState.Start;
        ambientMusicSciFi.enabled = false;
        ambientMusicHorror.enabled = false;
    }
   
    void Update()
    {
        SwitchState();
    }

    public void SwitchState()
    {
        switch(state)
        {
            case StoryState.Start:
                //webdingsTextStory.SetText(text.symboles["Alone"] + text.symboles["House"] + text.symboles["Moon"]+ text.symboles["Start"]+ text.symboles["Quit"]+ text.symboles["Pause"]+ text.symboles["Hear"]+ text.symboles["Bell"]+ text.symboles["Alien"]+ text.symboles["Flowers"]+ text.symboles["Invite"]+ text.symboles["No"]+ text.symboles["Sad"]+ text.symboles["Follow"]+ text.symboles["Earth"]+ text.symboles["Discussion"]+ text.symboles["Heart"]+ text.symboles["Radio"]+ text.symboles["Music"]+ text.symboles["Temperature"]+ text.symboles["Bed"]+ text.symboles["Pepper"]+ text.symboles["Scissor"]+ text.symboles["Happy"]+ text.symboles["See"]+ text.symboles["Someone"]+ text.symboles["Knife"]+ text.symboles["Bike"]+ text.symboles["Scream"]+ text.symboles["Forest"]+ text.symboles["Lightning"]+ text.symboles["Death"]+ text.symboles["Left"]+ text.symboles["Right"]+ text.symboles["Loop"]+ text.symboles["Present"]+ text.symboles["Open1"]+ text.symboles["Yeah!"]+ text.symboles["Martini"]+ text.symboles["Bomb"]);
                webdingsTextStory.SetText(text.symboles["Alone"] + text.symboles["House"] + text.symboles["Moon"]);
                webdingsTextOption1.SetText(text.symboles["Hear"]);
                webdingsTextOption2.SetText(text.symboles["See"]);

                ambientMusicSciFi.enabled = false;
                ambientMusicHorror.enabled = false;

                leftButton.buttonState = StoryState.Hear;
                rightButton.buttonState = StoryState.See;

                break;

            case StoryState.Hear:
                webdingsTextStory.SetText(text.symboles["Bell"] + text.symboles["Alien"] + text.symboles["Heart"]);
                webdingsTextOption1.SetText(text.symboles["Invite"]);
                webdingsTextOption2.SetText(text.symboles["Follow"]);

                ambientMusicSciFi.enabled = true;

                leftButton.buttonState = StoryState.Invite;
                rightButton.buttonState = StoryState.Follow;
                
                break;

            case StoryState.See:
                webdingsTextStory.SetText(text.symboles["Someone"] + text.symboles["Knife"]);
                webdingsTextOption1.SetText(text.symboles["Bike"]);
                webdingsTextOption2.SetText(text.symboles["Scream"]);

                ambientMusicHorror.enabled = true;

                leftButton.buttonState = StoryState.Bike;
                rightButton.buttonState = StoryState.Scream;

                break;

            case StoryState.Invite:
                webdingsTextStory.SetText(text.symboles["Alien"] + text.symboles["No"] + text.symboles["Sad"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;
                
                break;

            case StoryState.Follow:
                webdingsTextStory.SetText(text.symboles["Earth"] + text.symboles["Heart"] + text.symboles["Discussion"]);
                webdingsTextOption1.SetText(text.symboles["Radio"]);
                webdingsTextOption2.SetText(text.symboles["Temperature"]);

                leftButton.buttonState = StoryState.Radio;
                rightButton.buttonState = StoryState.Temperature;

                break;

            case StoryState.Radio:
                webdingsTextStory.SetText(text.symboles["Music"] + text.symboles["Alien"] + text.symboles["No"] + text.symboles["Sad"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;

                break;

            case StoryState.Temperature:
                webdingsTextStory.SetText(text.symboles["Bed"] + text.symboles["Pepper"] + text.symboles["Scissor"] + text.symboles["Happy"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;

                break;

            case StoryState.Bike:
                webdingsTextStory.SetText(text.symboles["Forest"] + text.symboles["Lightning"]);
                webdingsTextOption1.SetText(text.symboles["Left"]);
                webdingsTextOption2.SetText(text.symboles["Right"]);

                leftButton.buttonState = StoryState.Left;
                rightButton.buttonState = StoryState.Right;

                break;

            case StoryState.Scream:
                webdingsTextStory.SetText(text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;

                break;

            case StoryState.Left:
                webdingsTextStory.SetText(text.symboles["Present"]);
                webdingsTextOption1.SetText(text.symboles["Open1"]);
                webdingsTextOption2.SetText(text.symboles["Open2"]);

                leftButton.buttonState = StoryState.Open1;
                rightButton.buttonState = StoryState.Open2;

                break;

            case StoryState.Right:
                webdingsTextStory.SetText(text.symboles["Loop"] + text.symboles["House"] + text.symboles["Someone"] + text.symboles["Knife"] + text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;

                break;

            case StoryState.Open1:
                webdingsTextStory.SetText(text.symboles["Yeah!"] + text.symboles["House"] + text.symboles["Martini"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;
              
                break;

            case StoryState.Open2:
                webdingsTextStory.SetText(text.symboles["Bomb"] + text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                webdingsTextOption2.SetText(text.symboles["Start Again"]);

                leftButton.buttonState = StoryState.Start;
                rightButton.buttonState = StoryState.Start;

                break;
        }
    }
}
