using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardSettingsSave : MonoBehaviour
{
    public Color color;
    public string word;
    public  Image image;
    TextMeshProUGUI textMesh;

    public void Start()
    {
        image = GetComponent<Image>();
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        GetCardInfo();
    }
    public void Update()
    {
        
    }
    public void GetCardInfo()
    {
        color = image.color;
        word = textMesh.text;
    }
}
