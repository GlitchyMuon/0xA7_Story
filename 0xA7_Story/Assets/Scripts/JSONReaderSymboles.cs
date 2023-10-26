using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class JSONReaderSymboles : MonoBehaviour
{
    public TextAsset textJSON;
    public Dictionary<string, string> symboles;

    [System.Serializable]
    public class Words
    {
        public string key;
        public string value;
    }

    [System.Serializable]
    public class WordsData
    {
        public Words[] words;
    }


    void Start()
    {
        WordsData data = JsonUtility.FromJson<WordsData>(textJSON.text);

        symboles = new Dictionary<string, string>();
        foreach(Words word in data.words)
        {
            symboles.Add(word.key, word.value);
        }

        Debug.Log(symboles["Hear"]);
    }
}
