using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum StoryState{
        Start,
        Entendre,
        Inviter,
        Suivre,
        Musique,
        Temperature,
        Voir,
        Velo,
        Crier,
        Gauche,
        Droite,
        Ouvrir1,
        Ouvrir2
    }

    public StoryState state;
    public JSONReaderSymboles textSymbol;

    void Start()
    {
        state = StoryState.Start;
    }
   
    void Update()
    {
        switch(state)
        {
            case StoryState.Start:
                break;

            case StoryState.Entendre:
                break;

            case StoryState.Inviter:
                break;

            case StoryState.Suivre:
                break;

            case StoryState.Musique:
                break;

            case StoryState.Temperature:
                break;

            case StoryState.Voir:
                break;

            case StoryState.Velo:
                break;

            case StoryState.Crier:
                break;

            case StoryState.Gauche:
                break;

            case StoryState.Droite:
                break;

            case StoryState.Ouvrir1:
                break;

            case StoryState.Ouvrir2:
                break;
        }
    }
}
