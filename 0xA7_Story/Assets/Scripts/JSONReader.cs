using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class State
    {
        public string state;
        public string[] answer;
        public string[] options;
    }

    [System.Serializable]
    public class StateInfo
    {
        public State[] states;
    }

    public StateInfo stateInfo = new StateInfo();

    void Start()
    {
        stateInfo = JsonUtility.FromJson<StateInfo>(textJSON.text);
    }
}


