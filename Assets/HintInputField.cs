using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HintInputField : MonoBehaviour
{
 //   [SerializeField] private Button okButton;

    [SerializeField] private TMP_InputField hintInputField;
    [SerializeField] private TMP_InputField numberOfWordInputField;


    [SerializeField] private TextMeshProUGUI hintAndNumberText;
    [SerializeField] private List<GameObject> HitHistory = new List<GameObject>();
    [SerializeField] private ScrollView scrollView;
    [SerializeField] private Transform scrollViewVontentTransform;
    int hintDecalageYAxe = 0; 

    [SerializeField] private int distanceBetweenHints = 10;
    [SerializeField] int hintDecalageXAxe = 0;

    private void Start()
    {
      
    }
    private void Update()
    {
         
    }

    public void OnClickOk()
    {
       

        if (hintInputField != null && numberOfWordInputField != null)
        {
            if (string.IsNullOrWhiteSpace(hintInputField.text)) 
            {

                Debug.Log("Write your hint Plz");
            
            }
            if (string.IsNullOrWhiteSpace(numberOfWordInputField.text))
            {
                Debug.Log("Write your number of world");
            }

            
            else if (!string.IsNullOrWhiteSpace(numberOfWordInputField.text) && !string.IsNullOrWhiteSpace(hintInputField.text))
            {






               
                

                // Instantiate the prefab and set its parent to the contentPanel (the ScrollView Content)
                GameObject newText =  Instantiate( new GameObject()  , scrollViewVontentTransform   ) ;

                // Set the text content dynamically

                // Increment the index for the next item


              //  hintDecalageYAxe = hintDecalageYAxe + distanceBetweenHints;

                newText.transform.localPosition = new Vector3(hintDecalageXAxe, -hintDecalageYAxe, 0);





                TextMeshProUGUI textComponent = newText.AddComponent<TextMeshProUGUI>();
                textComponent.text = (hintInputField.text + " + " + numberOfWordInputField.text);


            }
        }
        
    }
}
