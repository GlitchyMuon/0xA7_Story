using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReaderSymboles : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Words
    {
        public string key;
        public string value;
    }

    [System.Serializable]
    public class WordsData
    {
        public Dictionary<string, string> wordsDictionary;
    }


    void Start()
    {
        WordsData data = JsonUtility.FromJson<WordsData>(textJSON.text);

        Dictionary<string, string> wordsDictionary = data.wordsDictionary;
    }
}
