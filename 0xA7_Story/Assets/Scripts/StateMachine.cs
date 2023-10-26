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
        Open2,
        Pause,
        Quit
    }

    public StoryState state;
    public JSONReaderSymboles text;
    
    [SerializeField]
    private TMP_Text webdingsTextStory;

    [SerializeField]
    private TMP_Text webdingsTextOption1;

    [SerializeField]
    private TMP_Text webdingsTextOption2;


    void Start()
    {

        state = StoryState.Start;
    }
   
    void Update()
    {

        SwitchState();
/*
        switch(state)
        {

            case StoryState.Start:
            
                break;

            case StoryState.Hear:
                break;

            case StoryState.Invite:
                break;

            case StoryState.Follow:
                break;

            case StoryState.Radio:
                break;

            case StoryState.Temperature:
                break;

            case StoryState.See:
                break;

            case StoryState.Bike:
                break;

            case StoryState.Scream:
                break;

            case StoryState.Left:
                break;

            case StoryState.Right:
                break;

            case StoryState.Open1:
                break;

            case StoryState.Open2:
                break;
            case StoryState.Pause:
                break;
        }
        */
 
    }

    void SwitchState()
    {
        switch(state)
        {
            case StoryState.Start:
                webdingsTextStory.SetText(text.symboles["Hear"] + text.symboles["House"] + text.symboles["Moon"]);
                webdingsTextOption1.SetText(text.symboles["Hear"]);
                webdingsTextOption2.SetText(text.symboles["See"]);

                // if button 1 is clicked -- state = Hear
                // if button 2 is clicked -- state = See

                break;

            case StoryState.Hear:
                webdingsTextStory.SetText(text.symboles["Bell"] + text.symboles["Alien"] + text.symboles["Flowers"]);
                webdingsTextOption1.SetText(text.symboles["Invite"]);
                webdingsTextOption2.SetText(text.symboles["Follow"]);
                
                break;

            case StoryState.See:
                webdingsTextStory.SetText(text.symboles["Someone"] + text.symboles["Knife"]);
                webdingsTextOption1.SetText(text.symboles["Bike"]);
                webdingsTextOption2.SetText(text.symboles["Scream"]);

                break;

            case StoryState.Invite:
                webdingsTextStory.SetText(text.symboles["Alien"] + text.symboles["No"] + text.symboles["Sad"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                
                break;

            case StoryState.Follow:
                webdingsTextStory.SetText(text.symboles["Heart"] + text.symboles["Discussion"]);
                webdingsTextOption1.SetText(text.symboles["Radio"]);
                webdingsTextOption2.SetText(text.symboles["Temperature"]);

                break;

            case StoryState.Radio:
                webdingsTextStory.SetText(text.symboles["Music"] + text.symboles["Alien"] + text.symboles["No"] + text.symboles["Sad"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);

                break;

            case StoryState.Temperature:
                webdingsTextStory.SetText(text.symboles["Bed"] + text.symboles["Pepper"] + text.symboles["Scissor"] + text.symboles["Happy"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);

                break;

            case StoryState.Bike:
                webdingsTextStory.SetText(text.symboles["Forest"] + text.symboles["Lightning"]);
                webdingsTextOption1.SetText(text.symboles["Left"]);
                webdingsTextOption2.SetText(text.symboles["Right"]);

                break;

            case StoryState.Scream:
                webdingsTextStory.SetText(text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);

                break;

            case StoryState.Left:
                webdingsTextStory.SetText(text.symboles["Present"]);
                webdingsTextOption1.SetText(text.symboles["Open1"]);
                webdingsTextOption2.SetText(text.symboles["Open2"]);

                break;

            case StoryState.Right:
                webdingsTextStory.SetText(text.symboles["Loop"] + text.symboles["House"] + text.symboles["Someone"] + text.symboles["Knife"] + text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);

                break;

            case StoryState.Open1:
                webdingsTextStory.SetText(text.symboles["Yeah!"] + text.symboles["House"] + text.symboles["Martini"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);
                
                break;

            case StoryState.Open2:
                webdingsTextStory.SetText(text.symboles["Bomb"] + text.symboles["Death"]);
                webdingsTextOption1.SetText(text.symboles["Start Again"]);

                break;

            case StoryState.Pause:

            //musique s'arrete
            //pour sortir de Pause, recliquer sur pause

                break;
        }
    }


}
