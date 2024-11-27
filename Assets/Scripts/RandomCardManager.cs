
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class WordList
{
    public List<string> words;
}
public class RandomCardManager : MonoBehaviour
{
    public WordList wordList;
    public TextAsset wordListJsonFile; // Public TextAsset to hold the JSON file



    [SerializeField] private List<GameObject> Cards = new List<GameObject>();





    private void Awake()
    {
        SetRandomColor();
        LoadWordList();
        SetRandomWord();
    }
  

     void SetRandomColor()
    {
        if (Cards.Count != 25)
        {
            Debug.LogError("There should be exactly 25 cards!");
            return;
        }

        // List of the card colors based on your specified quantities
        List<Color> cardColors = new List<Color>();

        // Add colors according to the quantities
        for (int i = 0; i < 7; i++) cardColors.Add(Color.red);    // 7 red
        for (int i = 0; i < 8; i++) cardColors.Add(Color.blue);   // 8 blue
        for (int i = 0; i < 9; i++) cardColors.Add(Color.white);  // 9 white
        cardColors.Add(Color.black);  // 1 black

        // Shuffle the list of colors randomly to apply them in random order
        Shuffle(cardColors);

        // Now assign colors to the cards
        for (int i = 0; i < Cards.Count; i++)
        {
            Image image = Cards[i].GetComponent<Image>();
            if (image != null)
            {
                image.color = cardColors[i];
            }
        }
    }
    void SetRandomWord()
    {
        Shuffle(wordList.words);

        // Now assign each word to the corresponding card's TextMeshProUGUI component
        for (int i = 0; i < Cards.Count; i++)
        {
            GameObject card = Cards[i];
            TextMeshProUGUI textMesh = card.GetComponentInChildren<TextMeshProUGUI>();
            if (textMesh != null)
            {
                textMesh.text = wordList.words[i];
            }
        }
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


    void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            T temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
