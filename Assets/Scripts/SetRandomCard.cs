using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class WordList
{
    public List<string> words;
}
public class SetRandomCard : MonoBehaviour
{

    public WordList wordList;
    public TextAsset wordListJsonFile; // Public TextAsset to hold the JSON file
    [SerializeField] private TMP_Text wordDisplay;


    public string[] colors = { "Red", "Blue", "White", "Black" };
    [SerializeField] private CardInfo cardInfo;

    private void Start()
    {

        LoadWordList();
        SetRandomColor();
        SetRandomWord();
    }

    public void SetRandomColor()
    {

        int randomIndex = Random.Range(0, colors.Length);
        cardInfo.Color = colors[randomIndex];
        Debug.Log(colors[randomIndex]);

    }
    void SetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.words.Count);
        cardInfo.Word = wordList.words[randomIndex];
        Debug.Log(wordList.words[randomIndex]);
    }

    void LoadWordList()
    {
        if (wordListJsonFile != null)
        {
            // Read the file's content
            string json = wordListJsonFile.text;

            // Deserialize JSON content into the WordList object
            wordList = JsonUtility.FromJson<WordList>(json);

            // Debug to see the output 
            Debug.Log("File Loaded");
        }
        else
        {
            Debug.LogError("JSON file not assigned!");
        }
    }
}


